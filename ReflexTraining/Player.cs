using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReflexTraining
{
    [Serializable]
    public class Player : ISerializable
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Type { get; set; }

        // Simple Employee constructor.
        public Player(string name, int score, int type)
        {
            this.Name = name;
            this.Score = score;
            this.Type = type;
        }

        private Player(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Score = info.GetInt32("Score");
            Type = info.GetInt32("Type");

        }

        public void GetObjectData(SerializationInfo inf, StreamingContext con)
        {
            inf.AddValue("Name", Name);
            inf.AddValue("Score", Score);
            inf.AddValue("Type", Type);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Name: {0}\r\n", Name);
            str.AppendFormat("Score: {0}\r\n", Score);
            str.AppendFormat("Type: {0}\r\n", Type);
            return str.ToString();
        }
    }
}
