using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FightTeamControl.Helpers
{
    public static class EnumHelper<T>
    {
        public static Dictionary<int, string> GetItems()
        {
            var items = new Dictionary<int, string>();

            var type = typeof(T);
            var values = Enum.GetValues(typeof(T));

            foreach (var value in values)
            {                
                var memInfo = type.GetMember(value.ToString());
                var attributes = memInfo[0].GetCustomAttributes(typeof(DisplayAttribute), false);

                if (attributes != null && attributes.Length > 0)
                {                                       
                    var display = attributes[0] as DisplayAttribute;
                    if (display != null)
                    {                            
                        var key = (byte)value;
                        string val = display.Description;

                        items.Add(key, val);
                    }                    
                }
            }

            return items;
        }        
    }
}