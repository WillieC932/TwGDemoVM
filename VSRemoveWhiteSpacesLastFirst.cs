using System;
using System.Text;
using System.Collections.Generic;
using Emc.InputAccel.IndexPlus.Scripting;
using Emc.InputAccel.QuickModule.ClientScriptingInterface;

namespace VSRemoveWhiteSpacesLastFirst
{
    public class FieldEvents
        : IFieldEvents
    {
        public void Initialize(IFieldEventInformation info)
        {
        }

        public void Changed(IFieldEventInformation info)
        {
            if (info.Sender.Id == "Last Name")
            {
                IIndexFields nodeFields = info.GetCurrentNodeFields();
                IIndexField lastName = nodeFields.GetFieldById("Last Name");
                if (lastName != null)
                {
                    lastName.Value = lastName.Value.Trim();
                }
            }
            if (info.Sender.Id == "First Name")
            {
                IIndexFields nodeFields = info.GetCurrentNodeFields();
                IIndexField firstName = nodeFields.GetFieldById("First Name");
                if (firstName != null)
                {
                    firstName.Value = firstName.Value.Trim();
                }
            }
        }

        public void Populate(IFieldEventInformation info)
        {
        }

        public ValidationResult Validate(IFieldEventInformation info, ValidationReason validationReason, Boolean silent)
        {
            return default(ValidationResult);
        }
    }
}
