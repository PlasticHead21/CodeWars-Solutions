using System;
using System.Collections.Generic;
using System.Text;

namespace DirectionsReduction
{
    internal class DirReduction
    {
        public static String[] Reduction(String[] arr)
        {
            if (arr is null)
                return arr;

            Stack<string> st = new Stack<string>();
            foreach (var item in arr)
            {   

                switch (item)
                {
                    case "NORTH":
                        if(st.Count != 0 && st.Peek() == "SOUTH")
                        {
                            st.Pop();
                        }
                        else
                        {
                            st.Push(item);
                        }
                        break;

                    case "SOUTH":
                        if (st.Count != 0 && st.Peek() == "NORTH")
                        {
                            st.Pop();
                        }
                        else
                        {
                            st.Push(item);
                        }
                        break;

                    case "WEST":
                        if (st.Count != 0 && st.Peek() == "EAST")
                        {
                            st.Pop();
                        }
                        else
                        {
                            st.Push(item);
                        }
                        break;

                    case "EAST":
                        if (st.Count != 0 && st.Peek() == "WEST")
                        {
                            st.Pop();
                        }
                        else
                        {
                            st.Push(item);
                        }
                        break;

                    default:
                        st.Push(item);
                        break;
                }
            }
            arr = st.ToArray();
            Array.Reverse(arr);
            return arr;
        }
    }
}
