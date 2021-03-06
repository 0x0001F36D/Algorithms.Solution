﻿// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
// License: CC BY-SA 4.0 https://creativecommons.org/licenses/by-sa/4.0/

namespace Algorithms.Solution.Utils
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    public sealed class HomeworkAttribute : Attribute
    {
        #region Public Constructors

        public HomeworkAttribute(int id)
            => this.Id = id;

        #endregion Public Constructors

        #region Public Properties

        public int Id { get; }

        #endregion Public Properties
    }
}