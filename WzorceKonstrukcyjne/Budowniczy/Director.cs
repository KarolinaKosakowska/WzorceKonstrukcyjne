using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceKonstrukcyjne.Budowniczy
{
    class Director
    {
        IFileBuildable _builder;
        public Director(IFileBuildable builder)
        {
            _builder = builder;
        }
        public void Construct(string text)
        {
            _builder.CreateFile();
            _builder.SetText(text);
        }
        public bool IsSuccess()
        {
            return File.Exists(_builder.Path);
        }
    }
}
