using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wallet.Models
{
    public static class RSA
    {
        public static string Sign(string privKey, string msgToSign)
        {
            var secret = Network.Main.CreateBitcoinSecret(privKey);
            var signature = secret.PrivateKey.SignMessage(msgToSign);
            //var bol = pkh.VerifyMessage(msgToSign, signature));
            var v = secret.PubKey.VerifyMessage(msgToSign, signature);
            return signature;
        }
    }
}
