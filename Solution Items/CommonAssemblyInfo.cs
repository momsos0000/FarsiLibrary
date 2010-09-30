using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using FarsiLibrary.Resources;
using System.Security;

[assembly: CLSCompliant(true)]
[assembly: AssemblyKeyFile(@"C:\FarsiLibrary.snk")]

[assembly: AssemblyVersion(AssemblyNames.Version)]
[assembly: AssemblyDescription(AssemblyNames.Description)]
[assembly: AssemblyCopyright(AssemblyNames.AssemblyCopyright)]
[assembly: AssemblyTrademark(AssemblyNames.AssemblyTradeMark)]
[assembly: AssemblyTitle(AssemblyNames.AssemblyGenericTitle)]

[assembly: InternalsVisibleTo("FarsiLibrary.Utils, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.Win, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.Resources, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.UnitTest, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.WPF, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.Web, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.Web.Mvc, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.WinFormDemo, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.WPFDemo, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.Demos.Web, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.Win.External, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
[assembly: InternalsVisibleTo("FarsiLibrary.LiveSamples, PublicKey=00240000048000009400000006020000002400005253413100040000010001000bd06c5f2139bb49786f0f662880bd6e984a64b40bfbedbd39f5893396c22b88366c9e1586bd2c9758e28063266d1b4cd521b89b9eb5f6332b4bf780fbb94926bd31416c0f4f2c4c4d95bc300241602447fdbf2b17cda756c51c4831f6f314fab2296bf319d9dbd2ef3a05dda68fd8495642aa5d376bfdd6fbfce193448893c4")]
