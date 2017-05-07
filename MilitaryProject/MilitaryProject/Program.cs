using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public interface Component
        {
            void Operation();
        }

        public class Composite : Component, IEnumerable
        {
            private System.Collections.Generic.List<Component> _children = new System.Collections.Generic.List<Component>();
            public void AddChild(Component child)
            {
                _children.Add(child);
            }
            public void RemoveChild(Component child)
            {
                _children.Remove(child);
            }
            public Component GetChild(int index)
            {
                return _children[index];
            }
            public void Operation()
            {
                string message = string.Format("Composite with {0} child(ren)", _children.Count);
                Console.WriteLine(message);
            }
            public IEnumerator GetEnumerator()
            {
                foreach (Component child in _children)
                    yield return child;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        public class Leaf : Component
        {
            public void Operation()
            {
                Console.WriteLine("Leaf");
            }
        }
    }
}
