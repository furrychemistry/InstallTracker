using System;
using System.Collections.Generic;
using System.IO;

namespace InstallTracker
{
	sealed class ListBoxEntry
	{
		public readonly FileInfo Info;
		public readonly string Name;

		public ListBoxEntry(FileInfo file) => Name = (Info = file).Name;

		public override string ToString() => Name;
	}
}
