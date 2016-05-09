using System.Reflection;
using Eplan.EplApi.ApplicationFramework;

namespace Suplanus.EplAddin.AddinTemplate1
{
   class Action : IEplAction
   {
      public void GetActionProperties(ref ActionProperties actionProperties) { }

      public bool OnRegister(ref string name, ref int ordinal)
      {
         // ReSharper disable once PossibleNullReferenceException
         name = MethodBase.GetCurrentMethod().DeclaringType.Name; // Get name from class
         ordinal = 20;
         return true;
      }

      public bool Execute(ActionCallingContext oActionCallingContext)
      {

         return true;
      }
   }
}
