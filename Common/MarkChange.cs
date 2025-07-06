using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Common.Cryptography;

namespace Common
{
    public class MarkChange
    {
        public List<Measurement> dataToModify;
        public List<Measurement> listWithNewEntities;
        public List<Measurement> listWithDeletedEntities;
        public bool newEntitiesAdded = false;
        public bool entitiesDeleted = false;
        public bool dataChanged = false;
        public bool notification = false;
        public readonly Aes myAes = Aes.Create();
        public readonly AES aes = new AES();
        public readonly SecretMasks sm = new SecretMasks();
        public int counterForID = 0;
        public string fileName = "";
    }
}
