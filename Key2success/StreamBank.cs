using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class StreamBank
    {
        private string reader;
        private string v;

        public StreamBank(string v)
        {
            this.v = v;
        }

        static void Main(string[] args)
        {

            StreamWriter reader = new StreamWriter("C:/Documents/visual studio 2015/Projects/Key2success");


            int lineNumber = 0;

            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();

            }
            reader.Close();
        }

        internal void Write(Action streamMe)
        {
            throw new NotImplementedException();
        }
    }
}
