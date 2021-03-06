using Hyper.DotNet.Commands.Common.Constants;
using CodeFactory;
using CodeFactory.DotNet.CSharp;
using CodeFactory.VisualStudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.DotNet.Commands.ExplorerCommands.SourceCode.Extensions
{
    /// <summary>
    /// Class that holds extension methods used for namespace management.
    /// </summary>
    public static class NamespaceExtensions
    {
        public static string GetRootFromNamespace(this CsContainer source)
        {
            return source.Namespace.Substring(0, source.Namespace.IndexOf("."));
        }
    }
}
