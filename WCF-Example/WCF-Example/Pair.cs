using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_Example
{
    [DataContract]
    public class Pair
    {
        private int m_first;
        private int m_second;

        public Pair()
        {
            m_first = 0;
            m_second = 0;
        }

        public Pair(int first, int second)
        {
            m_first = first;
            m_second = second;
        }

        [DataMember]
        public int First
        {
            get { return m_first; }
            set { m_first = value; }
        }

        [DataMember]
        public int Second
        {
            get { return m_second; }
            set { m_second = value; }
        }
    }
}