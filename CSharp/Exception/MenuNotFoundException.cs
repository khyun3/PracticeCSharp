using CSharp.Properties;

namespace CSharp.Exception
{
    public class MenuNotFoundException : System.Exception
    {
        public MenuNotFoundException()
        {
            throw new System.Exception(Constants.MENU_IS_NOT_EXIST);
        }
    }
}