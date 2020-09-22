using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AjTypeSystem']"
	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/AjTypeSystem", DoNotGenerateAcw=true)]
	public partial class AjTypeSystem : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/aspectj/lang/reflect/AjTypeSystem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AjTypeSystem); }
		}

		protected AjTypeSystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AjTypeSystem']/constructor[@name='AjTypeSystem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AjTypeSystem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AjTypeSystem)) {
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

		static IntPtr id_getAjType_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/class[@name='AjTypeSystem']/method[@name='getAjType' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAjType", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/AjType;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Org.Aspectj.Lang.Reflect.IAjType GetAjType (global::Java.Lang.Class fromClass)
		{
			if (id_getAjType_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAjType_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getAjType", "(Ljava/lang/Class;)Lorg/aspectj/lang/reflect/AjType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fromClass);
				global::Org.Aspectj.Lang.Reflect.IAjType __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAjType_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
