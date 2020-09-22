using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='InheritanceUtils']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/reflect/InheritanceUtils", DoNotGenerateAcw=true)]
	public partial class InheritanceUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/reflect/InheritanceUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InheritanceUtils); }
		}

		protected InheritanceUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='InheritanceUtils']/constructor[@name='InheritanceUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InheritanceUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InheritanceUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_distance_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.reflect']/class[@name='InheritanceUtils']/method[@name='distance' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("distance", "(Ljava/lang/Class;Ljava/lang/Class;)I", "")]
		public static unsafe int Distance (global::Java.Lang.Class child, global::Java.Lang.Class parent)
		{
			if (id_distance_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
				id_distance_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "distance", "(Ljava/lang/Class;Ljava/lang/Class;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (child);
				__args [1] = new JValue (parent);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_distance_Ljava_lang_Class_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
