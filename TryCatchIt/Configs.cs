using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchIt
{
    class Configs
    {
        private static int XSizeField = 730;
        private static int YSizeField = 680;

        private static int XSizeFood;
        private static int YSizeFood;

        private static int XSizePlayer = 80;
        private static int YSizePlayer = 110;

        public int getFieldX()
        {
            return XSizeField;
        }

        public int getFieldY()
        {
            return YSizeField;
        }

        public int getFoodX()
        {
            return XSizeFood;
        }

        public int getFoodY()
        {
            return YSizeFood;
        }

        public int getPlayerX()
        {
            return XSizePlayer;
        }

        public int getPlayerY()
        {
            return YSizePlayer;
        }
    }
}
