/****************************************************************************
 * Copyright (c) 2018 ~ 2020.10 liangxie
 * 
 * https://qframework.cn
 * https://github.com/liangxiegame/QFramework
 * https://gitee.com/liangxiegame/QFramework
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 ****************************************************************************/

#if UNITY_5_6_OR_NEWER

namespace QFramework
{
    /// <summary>
    /// 支持链式方法
    /// </summary>
    public class SequenceNodeChain : ActionChain
    {
        protected override Action mNode
        {
            get { return mSequence; }
        }

        private Sequence mSequence;

        public SequenceNodeChain()
        {
            mSequence = new Sequence();
        }

        public override IActionChain Append(IAction node)
        {
            mSequence.Append(node);
            return this;
        }

        protected override void OnDispose()
        {
            base.OnDispose();

            mSequence.Dispose();
            mSequence = null;
        }
    }
}

#endif