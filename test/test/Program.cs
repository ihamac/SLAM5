using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cet objet est utilisé par le service de chiffrement
            // pour créer les clés
            CspParameters cspParams = new CspParameters();

            // Les clés publique et privée
            RSAParameters privateKeys;
            RSAParameters publicKeys;

            using (var rsa = new RSACryptoServiceProvider(cspParams))
            {
                // Génère la clé publique et la clé privée
                privateKeys = rsa.ExportParameters(true);
                publicKeys = rsa.ExportParameters(false);

                rsa.Clear();
            }

            string texte = "Allo le monde";

            Console.WriteLine("Texte  en clair {0}: ", texte);

            // La clé publique est utilisée pour chiffrer les données
            byte[] cryptedBytes = Encrypt(texte, publicKeys);

            Console.WriteLine("Texte chiffré {0}", Convert.ToBase64String(cryptedBytes));

            // La clé privée est utilisée pour déchiffrer les données
            Console.WriteLine("Text déchiffré {0}", Decrypt(cryptedBytes, privateKeys));
            Console.ReadLine();
        }

        static byte[] Encrypt(string value, RSAParameters rsaKeyInfo)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Récupère les infos de la clé publique
                rsa.ImportParameters(rsaKeyInfo);

                byte[] encodedData = Encoding.Default.GetBytes(value);

                // Chiffre les données.
                // Les données chiffrées sont retournées sous la forme d'un tableau de bytes
                byte[] encryptedData = rsa.Encrypt(encodedData, true);

                rsa.Clear();

                return encryptedData;
            }
        }

        static string Decrypt(byte[] encryptedData, RSAParameters rsaKeyInfo)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Récupère les infos de la clé privée
                rsa.ImportParameters(rsaKeyInfo);

                // Déchiffre les données.
                // Les données déchiffrées sont retournées sous la forme d'un tableau de bytes
                byte[] decryptedData = rsa.Decrypt(encryptedData, true);

                string decryptedValue = Encoding.Default.GetString(decryptedData);

                rsa.Clear();

                return decryptedValue;
            }
        }


    }


}
