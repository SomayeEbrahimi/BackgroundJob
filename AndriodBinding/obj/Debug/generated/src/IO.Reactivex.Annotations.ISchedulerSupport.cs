using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Annotations {

	[Register ("io/reactivex/annotations/SchedulerSupport", DoNotGenerateAcw=true)]
	public abstract class SchedulerSupport : Java.Lang.Object {

		internal SchedulerSupport ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']/field[@name='COMPUTATION']"
		[Register ("COMPUTATION")]
		public const string Computation = (string) "io.reactivex:computation";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']/field[@name='CUSTOM']"
		[Register ("CUSTOM")]
		public const string Custom = (string) "custom";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']/field[@name='IO']"
		[Register ("IO")]
		public const string Io = (string) "io.reactivex:io";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']/field[@name='NEW_THREAD']"
		[Register ("NEW_THREAD")]
		public const string NewThread = (string) "io.reactivex:new-thread";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']/field[@name='NONE']"
		[Register ("NONE")]
		public const string None = (string) "none";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']/field[@name='SINGLE']"
		[Register ("SINGLE")]
		public const string Single = (string) "io.reactivex:single";

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']/field[@name='TRAMPOLINE']"
		[Register ("TRAMPOLINE")]
		public const string Trampoline = (string) "io.reactivex:trampoline";

		// The following are fields from: java.lang.annotation.Annotation

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable

		// The following are fields from: Java.Interop.IJavaPeerable
	}

	[Register ("io/reactivex/annotations/SchedulerSupport", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'SchedulerSupport' type. This type will be removed in a future release.", error: true)]
	public abstract class SchedulerSupportConsts : SchedulerSupport {

		private SchedulerSupportConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']"
	[Register ("io/reactivex/annotations/SchedulerSupport", "", "IO.Reactivex.Annotations.ISchedulerSupportInvoker")]
	public partial interface ISchedulerSupport : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.annotations']/interface[@name='SchedulerSupport']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()Ljava/lang/String;", "GetValueHandler:IO.Reactivex.Annotations.ISchedulerSupportInvoker, AndriodBinding")]
		string Value ();

	}

	[global::Android.Runtime.Register ("io/reactivex/annotations/SchedulerSupport", DoNotGenerateAcw=true)]
	internal partial class ISchedulerSupportInvoker : global::Java.Lang.Object, ISchedulerSupport {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/annotations/SchedulerSupport");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISchedulerSupportInvoker); }
		}

		IntPtr class_ref;

		public static ISchedulerSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISchedulerSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.annotations.SchedulerSupport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISchedulerSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_value;
#pragma warning disable 0169
		static Delegate GetValueHandler ()
		{
			if (cb_value == null)
				cb_value = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Value);
			return cb_value;
		}

		static IntPtr n_Value (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.ISchedulerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value ());
		}
#pragma warning restore 0169

		IntPtr id_value;
		public unsafe string Value ()
		{
			if (id_value == IntPtr.Zero)
				id_value = JNIEnv.GetMethodID (class_ref, "value", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.ISchedulerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.ISchedulerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (obj);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.ISchedulerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Annotations.ISchedulerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
