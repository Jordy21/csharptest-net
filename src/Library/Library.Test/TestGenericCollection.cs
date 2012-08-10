﻿#region Copyright 2011-2012 by Roger Knapp, Licensed under the Apache License, Version 2.0
/* Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#endregion
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpTest.Net.Library.Test
{
    public abstract class TestGenericCollection<TList, TItem> 
        where TList : ICollection<TItem>, new()
    {
        protected abstract TItem[] GetSample();

        [Test]
        public void TestAddRemove()
        {
            TList list = new TList();
            TItem[] items = GetSample();

            int count = 0;
            Assert.AreEqual(count, list.Count);

            foreach (TItem item in items)
            {
                list.Add(item);
                Assert.AreEqual(++count, list.Count);
            }
            foreach (TItem item in items)
            {
                Assert.IsTrue(list.Remove(item));
                Assert.AreEqual(--count, list.Count);
            }
        }

        [Test]
        public void TestAddReverseRemove()
        {
            TList list = new TList();
            TItem[] items = GetSample();

            int count = 0;
            Assert.AreEqual(count, list.Count);

            foreach (TItem item in items)
            {
                list.Add(item);
                Assert.AreEqual(++count, list.Count);
            }
            for (int ix = items.Length - 1; ix >= 0; ix--)
            {
                Assert.IsTrue(list.Remove(items[ix]));
                Assert.AreEqual(--count, list.Count);
            }
        }

        [Test]
        public void TestClear()
        {
            TList list = new TList();
            TItem[] items = GetSample();

            foreach (TItem item in items)
                list.Add(item);
            Assert.AreEqual(items.Length, list.Count);

            Assert.AreNotEqual(0, list.Count);
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void TestContains()
        {
            TList list = new TList();
            TItem[] items = GetSample();

            foreach (TItem item in items)
                list.Add(item);
            Assert.AreEqual(items.Length, list.Count);

            foreach (TItem item in items)
                Assert.IsTrue(list.Contains(item));
        }

        [Test]
        public void TestCopyTo()
        {
            TList list = new TList();
            List<TItem> items = new List<TItem>(GetSample());

            foreach (TItem item in items)
                list.Add(item);
            Assert.AreEqual(items.Count, list.Count);

            TItem[] copy = new TItem[items.Count + 1];
            list.CopyTo(copy, 1);
            Assert.AreEqual(default(TItem), copy[0]);

            for (int i = 1; i < copy.Length; i++)
                Assert.IsTrue(items.Remove(copy[i]));

            Assert.AreEqual(0, items.Count);
        }

        [Test]
        public void TestIsReadOnly()
        {
            Assert.IsFalse(new TList().IsReadOnly);
        }

        [Test]
        public void TestGetEnumerator()
        {
            TList list = new TList();
            List<TItem> items = new List<TItem>(GetSample());

            foreach (TItem item in items)
                list.Add(item);
            Assert.AreEqual(items.Count, list.Count);

            foreach (TItem item in list)
                Assert.IsTrue(items.Remove(item));

            Assert.AreEqual(0, items.Count);
        }

        [Test]
        public void TestGetEnumerator2()
        {
            TList list = new TList();
            List<TItem> items = new List<TItem>(GetSample());

            foreach (TItem item in items)
                list.Add(item);
            Assert.AreEqual(items.Count, list.Count);

            foreach (TItem item in ((System.Collections.IEnumerable)list))
                Assert.IsTrue(items.Remove(item));

            Assert.AreEqual(0, items.Count);
        }
    }
}