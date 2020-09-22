using System;

namespace IO.Objectbox.Annotation {

	[global::Android.Runtime.Annotation ("io.objectbox.annotation.Entity")]
	public partial class EntityAttribute : Attribute
	{
		[global::Android.Runtime.Register ("useNoArgConstructor")]
		public bool UseNoArgConstructor { get; set; }

	}
}
