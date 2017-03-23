﻿using System;
using Cake.Core.IO;
using Cake.CsvHelpers;
using NSubstitute;
using Should;
using Xunit;

namespace Cake.CsvHelper.Tests
{
    public sealed class CsvHelperAliasesTests
    {
        public sealed class TheReadCsvMethod
        {
            [Fact]
            public void Should_Throw_If_Context_Is_Null()
            {
                // Given
                var file = Substitute.For<IFile>();
                //var environment = Substitute.For<ICakeEnvironment>();
                //var context = Substitute.For<ICakeContext>();
                //context.Environment.Returns(environment);

                // When
                var result = Record.Exception(() => CsvHelperAliases.ReadCsv<Person>(null, file.Path));

                // Then
                result.ShouldBeType<ArgumentNullException>().ParamName.ShouldEqual("context");
            }
        }
    }

    public sealed class Person
    {
        public int Id { get; set; }
    }
}
