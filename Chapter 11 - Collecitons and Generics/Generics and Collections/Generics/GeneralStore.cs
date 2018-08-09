using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMonday.Generics
{
    class GeneralStore
    {

        private object data;

       public GeneralStore(object data) {
            this.data = data;
        }

        public object Data {
            get {
                return this.data;
            }
            set {
                this.data = value;
            }
        }
    }

    class GenericStore<T> {
        private T data;

        public GenericStore(T data)
        {
            this.data = data;
        }

        public object Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = (T)value;
            }
        }

        public void setData(T data) {
            this.data = data;
        }
    }
}
