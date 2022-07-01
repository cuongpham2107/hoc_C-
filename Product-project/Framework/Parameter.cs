using System;

namespace Framework
{
    public class Parameter
    {
        private readonly Dictionary<string, string> _pairs = new Dictionary<string, string>();
        /// <summary>
        /// Nạp chồng phép toán indexing[]; cho phép truy xuất giá trị theo kiểu bến[khoá] = giá_tri;
        /// </summary>
        /// <param name="key">Khoá </param>
        /// <returns>giá trị tương ứng</returns>
        public string this[string key]//để nạp chồng phép toán indexing phải viết hai phương thức get,set
        {
            get
            {
                if (_pairs.ContainsKey(key))
                    return _pairs[key];
                else return null;
            }//Phương thức get trả lại giá trị từ dictionary
            set => _pairs[key] = value;//phương thức set gán giá trị cho dictionary
        }
        /// <summary>
        /// Kiểm tra xem một khoá có trong danh sách tham số không
        /// </summary>
        /// <param name="key">Khoá cần kiểm tra</param>
        /// <returns></returns>
        public bool ContainsKey(string key)
        {
            return _pairs.ContainsKey(key);
        }

        public Parameter(string parameter)
        {
            var pairs = parameter.Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var pair in pairs)
            {
                var p = pair.Split('=');//cắt mỗi phần tử lấy mốc là ký tự  = 
                if (p.Length == 2)//một cặp khoá  = giá trị đúng sau khi cắt sẽ phải có 2 phần
                {
                    var key = p[0].Trim();//phần tử thứ nhất là khoá
                    var value = p[1].Trim();//Phần tử thứ 2 là giá trị
                    this[key] = value; //lưu cặp khoá-giá trị này lại sử dụng phép toán indexing
                    //cũng có thể viết theo kiểu khác, trực tiếp sử dụng biến _pairs
                    //_pairs[key] = value;
                }
            }
        }
    }
}