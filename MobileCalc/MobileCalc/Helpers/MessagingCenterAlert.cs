﻿//
// MessagingCenterAlert.cs
//
// Author:
//       Piotr Niżnik <piotrek84nn@gmail.com>
//
// Copyright (c) 2017 (c) Piotr Niżnik
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using System;

namespace MobileCalc
{
    public class MessagingCenterAlert
    {
        /// <summary>
        /// Init this instance.
        /// </summary>
        public static void Init()
        {
            var time = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance cancel/OK text.
        /// </summary>
        /// <value><c>true</c> if this instance cancel; otherwise, <c>false</c>.</value>
        public string Cancel { get; set; }

        /// <summary>
        /// Gets or sets the OnCompleted Action.
        /// </summary>
        /// <value>The OnCompleted Action.</value>
        public Action OnCompleted { get; set; }
    }
}