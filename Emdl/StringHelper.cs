using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emdl {
    public static class StringHelper {
        /// <summary>
        /// Gets all the text within the first curlybracket pair
        /// </summary>
        /// <param name="commandBody"></param>
        /// <returns></returns>
        public static string GetFirstBody(string commandBody) {
            int startindex = commandBody.IndexOf('{');
            if (startindex == -1) {
                return "";
            }
            int index = startindex;
            int count = 1;

            while (count != 0) {
                index++;
                char c = commandBody[index];

                if (c == '{') {
                    count++;
                } else if (c == '}') {
                    count--;
                }
            }

            int endIndex = index;
            return commandBody.Substring(startindex + 1, endIndex - (startindex + 1));
        }

        public static string GetCommandOfLine(string line) {
            string l = line.Trim();
            int index = l.IndexOf(' ');
            if (index == -1) {
                return "err";
            }
            return l.Substring(0, index);
        }
    }
}
