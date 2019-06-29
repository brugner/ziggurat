using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Management
{
   class FormValidator
   {
      public static bool HasValidationErrors(ControlCollection controls)
      {
         bool hasError = false;

         // Now we need to loop through the controls and deterime if any of them have errors
         foreach (Control control in controls)
         {
            // check the control and see what it returns
            bool validControl = IsValid(control);

            // If it's not valid then set the flag and keep going.  We want to get through all
            // the validators so they will display on the screen if errorProviders were used.
            if (!validControl)
               hasError = true;

            // If its a container control then it may have children that need to be checked
            if (control.HasChildren)
               if (HasValidationErrors(control.Controls))
                  hasError = true;
         }

         return hasError;
      }

      // Here, let's determine if the control has a validating method attached to it
      // and if it does, let's execute it and return the result
      private static bool IsValid(object eventSource)
      {
         var name = "EventValidating";
         var targetType = eventSource.GetType();

         do
         {
            var fields = targetType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var field in fields)
            {
               if (field.Name == name)
               {
                  var eventHandlers = ((EventHandlerList)(eventSource.GetType().GetProperty("Events", (BindingFlags.FlattenHierarchy | (BindingFlags.NonPublic | BindingFlags.Instance))).GetValue(eventSource, null)));
                  var d = eventHandlers[field.GetValue(eventSource)];

                  if ((!(d == null)))
                  {
                     var subscribers = d.GetInvocationList();

                     // ok we found the validation event,  let's get the event method and call it
                     foreach (var delegatte in subscribers)
                     {
                        // create the parameters
                        object sender = eventSource;
                        var eventArgs = new CancelEventArgs();
                        eventArgs.Cancel = false;

                        object[] parameters = new object[2];
                        parameters[0] = sender;
                        parameters[1] = eventArgs;

                        // call the method
                        delegatte.DynamicInvoke(parameters);

                        // if the validation failed we need to return that failure
                        if (eventArgs.Cancel)
                           return false;
                        else
                           return true;
                     }
                  }
               }
            }

            targetType = targetType.BaseType;

         } while (targetType != null);

         return true;
      }
   }
}
