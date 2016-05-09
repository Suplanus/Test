using Eplan.EplApi.ApplicationFramework;

namespace Suplanus.EplAddin.AddinTemplate1
{
   public class AddInModule : IEplAddIn
   {
      public bool OnRegister(ref bool isLoadingOnStart)
      {
         isLoadingOnStart = true;
         return true;
      }

      public bool OnUnregister()
      {
         return true;
      }

      public bool OnInit()
      {
         return true;
      }

      public bool OnInitGui()
      {
         return true;
      }

      public bool OnExit()
      {
         return true;
      }

   }
}
