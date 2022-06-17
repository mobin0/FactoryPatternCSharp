using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    static class AppFactory
    {
        public static ICallable GetApp(string type) {
            ICallable app;

            switch (type.ToLower()) {

                case "c#":
                case "c sharp":
                    app = new CSharp();
                    break;
                case "javascript":
                case "js":
                    app = new JS();
                    break;
                case "python":
                case "py":
                    app = new Python();
                    break;

                default:
                    app = null;
                        break;

            }
            return app;
        
        }

    }
}
