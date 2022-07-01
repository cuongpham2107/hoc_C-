using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_project.Framework
{
    internal class ViewBase
    {
        protected object Model;
        protected Router Router = Router.Instance;
        public ViewBase()
        {

        }
        public ViewBase(object model)
        {
            Model = model; 
        }
        //bổ sung phươgn thức virtual Render, cho phép ghi đè
        public virtual void Render() { }
        //chuyển phương thức RenderToFile sang virtual
        public void RenderToFile(string path)
        {
            ViewHelp.WriteLine($"Lưu dữ liệu vào file '{path}'");
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Model);
            File.WriteAllText(path, json);
            ViewHelp.WriteLine("Done!");

        }
    }
}
