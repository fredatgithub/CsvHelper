﻿// Copyright 2009-2019 Josh Close and Contributors
// This file is a part of CsvHelper and is dual licensed under MS-PL and Apache 2.0.
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html for MS-PL and http://opensource.org/licenses/Apache-2.0 for Apache 2.0.
// https://github.com/JoshClose/CsvHelper
using System;


namespace CsvHelper.Configuration.Attributes
{
    /// <summary>
    /// A base class that enables pluggable
    /// configuration of member mapping.
    /// </summary>
    public interface IMemberReferenceMapper
    {
        void ApplyTo(MemberReferenceMap referenceMap);

    }
}