﻿using System;
using System.Collections.Generic;
using System.Text;
using number = System.Double;

namespace slagtool.runtime.builtin
{
    public class kit
    {
        public static string NL { get { return Environment.NewLine;  } }

        public static void check_num_of_args(object[] ol,int n)
        {
            if (ol==null || ol.Length != n)
            {
                error("the number of arguments is not mutch.");
            }
        }
        public static object get_ol_at(object[] ol,int n)
        {
            if (ol==null || n < 0 || ol.Length<=n ) return null;
            return ol[n];
        }
        public static string get_string_at(object[] ol,int n)
        {
            if (ol==null || n < 0 || ol.Length<=n || ol[n]==null ) return null;
            return ol[n].ToString();
        }
        public static string convert_escape(object o)
        {
            if (o==null) return "";
            var s = o.ToString();
            return s.Replace("\\n",NL);
        }
        public static number get_number_at(object[] ol, int n)
        {
            var o = get_ol_at(ol,n);
            if (o==null) return number.NaN;
            if (util.IsNumeric(o.GetType())) return util.ToNumber(o);
            number x;
            if (number.TryParse(o.ToString(),out x))
            {
                return x;
            }
            return number.NaN;
        }
        public static List<object> get_list_at(object[] ol, int n)
        {
            var o = get_ol_at(ol, n);
            if (o == null) return null;
            if (o.GetType() == typeof(List<object>)) return (List<object>)o;
            return null;
        }
        // Error
        public static void error(string cmt)
        {
            var s = cmt + YDEF_DEBUG.RuntimeErrorInfo();
            throw new SystemException(s);
        }
        public static Type FindType(string s)
        {
            return slagtool.runtime.sub_pointervar_clause.find_typeinfo(s);
        }

    }
}
