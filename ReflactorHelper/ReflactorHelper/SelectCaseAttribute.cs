/// ReflactorHelper, and with Custom Attribute could remove the switch case in your code 2018-03-02
/// Gilbert Zhang ca.qc.gilbert@gmail.com

namespace HelpLibrary
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ConditionAttribute : System.Attribute
    {
        public ConditionAttribute(string functionName, string conditionString)
        {
            this.FunctionName = functionName;
            this.ConditionString = conditionString;
        }

        public string FunctionName { get; set; }

        public string ConditionString { get; set; }
    }
}
