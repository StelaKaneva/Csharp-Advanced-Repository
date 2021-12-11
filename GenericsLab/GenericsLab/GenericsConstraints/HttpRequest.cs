using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsConstraints
{
    public class HttpRequest<T> where T: class
    {
        public void Send(T data)
        {
            Console.WriteLine("Sending all the data to the WWW" + data);
        }
    }
}
