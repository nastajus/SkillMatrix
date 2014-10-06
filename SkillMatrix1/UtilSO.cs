using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatrix1
{
    public static class UtilSO
    {
        //the purpose of this class is to segregate my efforts practicing OO away from copy-pasted answers from Stack Overflow

        //http://stackoverflow.com/questions/2566101/how-to-get-variable-name-using-reflection
        public static string GetVariableName<T>(Expression<Func<T>> expr)
        {
            var body = (MemberExpression)expr.Body;

            return body.Member.Name;
        }

    }
}
