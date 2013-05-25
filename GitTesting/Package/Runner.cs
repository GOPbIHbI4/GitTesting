using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTesting
{
    public class Runner
    {
        private Reader _reader;
        private Writer _writer;

        public Runner()
        {
            this._writer = new Writer();
            this._reader = new Reader();
        }

        /// <summary>
        /// Runner
        /// </summary>
        public void Run()
        {
            this._writer.Write();
            this._reader.Read();
        }
    }
}
