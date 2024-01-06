using System.ComponentModel.DataAnnotations;

namespace DoHuyHoang781.Models
{
    public class StringProcessDHH781
    {
        public string LowerToUpper(string str){
            var str2 = str.ToUpper();
            return str2;
        }
    }
}