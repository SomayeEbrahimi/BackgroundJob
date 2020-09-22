using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Tuple {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/tuple/Triple", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L", "M", "R"})]
	public abstract partial class Triple : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/tuple/Triple", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Triple); }
		}

		protected Triple (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/constructor[@name='Triple' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Triple ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Triple)) {
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

		static Delegate cb_getLeft;
#pragma warning disable 0169
		static Delegate GetGetLeftHandler ()
		{
			if (cb_getLeft == null)
				cb_getLeft = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLeft);
			return cb_getLeft;
		}

		static IntPtr n_GetLeft (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.Triple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawLeft);
		}
#pragma warning restore 0169

		protected abstract global::Java.Lang.Object RawLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='getLeft' and count(parameter)=0]"
			[Register ("getLeft", "()Ljava/lang/Object;", "GetGetLeftHandler")] get;
		}

		static Delegate cb_getMiddle;
#pragma warning disable 0169
		static Delegate GetGetMiddleHandler ()
		{
			if (cb_getMiddle == null)
				cb_getMiddle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMiddle);
			return cb_getMiddle;
		}

		static IntPtr n_GetMiddle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.Triple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawMiddle);
		}
#pragma warning restore 0169

		protected abstract global::Java.Lang.Object RawMiddle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='getMiddle' and count(parameter)=0]"
			[Register ("getMiddle", "()Ljava/lang/Object;", "GetGetMiddleHandler")] get;
		}

		static Delegate cb_getRight;
#pragma warning disable 0169
		static Delegate GetGetRightHandler ()
		{
			if (cb_getRight == null)
				cb_getRight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRight);
			return cb_getRight;
		}

		static IntPtr n_GetRight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.Triple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawRight);
		}
#pragma warning restore 0169

		protected abstract global::Java.Lang.Object RawRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='getRight' and count(parameter)=0]"
			[Register ("getRight", "()Ljava/lang/Object;", "GetGetRightHandler")] get;
		}

		static Delegate cb_compareTo_Lorg_apache_commons_lang3_tuple_Triple_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lorg_apache_commons_lang3_tuple_Triple_Handler ()
		{
			if (cb_compareTo_Lorg_apache_commons_lang3_tuple_Triple_ == null)
				cb_compareTo_Lorg_apache_commons_lang3_tuple_Triple_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Lorg_apache_commons_lang3_tuple_Triple_);
			return cb_compareTo_Lorg_apache_commons_lang3_tuple_Triple_;
		}

		static int n_CompareTo_Lorg_apache_commons_lang3_tuple_Triple_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.Triple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.Triple> (native_other, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lorg_apache_commons_lang3_tuple_Triple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.tuple.Triple&lt;L, M, R&gt;']]"
		[Register ("compareTo", "(Lorg/apache/commons/lang3/tuple/Triple;)I", "GetCompareTo_Lorg_apache_commons_lang3_tuple_Triple_Handler")]
		public virtual unsafe int CompareTo (global::Org.Apache.Commons.Lang3.Tuple.Triple other)
		{
			if (id_compareTo_Lorg_apache_commons_lang3_tuple_Triple_ == IntPtr.Zero)
				id_compareTo_Lorg_apache_commons_lang3_tuple_Triple_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lorg/apache/commons/lang3/tuple/Triple;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lorg_apache_commons_lang3_tuple_Triple_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lorg/apache/commons/lang3/tuple/Triple;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='of' and count(parameter)=3 and parameter[1][@type='L'] and parameter[2][@type='M'] and parameter[3][@type='R']]"
		[Register ("of", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Triple;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"L", "M", "R"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Tuple.Triple Of (global::Java.Lang.Object left, global::Java.Lang.Object middle, global::Java.Lang.Object right)
		{
			if (id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "of", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/Triple;");
			IntPtr native_left = JNIEnv.ToLocalJniHandle (left);
			IntPtr native_middle = JNIEnv.ToLocalJniHandle (middle);
			IntPtr native_right = JNIEnv.ToLocalJniHandle (right);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_left);
				__args [1] = new JValue (native_middle);
				__args [2] = new JValue (native_right);
				global::Org.Apache.Commons.Lang3.Tuple.Triple __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.Triple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_left);
				JNIEnv.DeleteLocalRef (native_middle);
				JNIEnv.DeleteLocalRef (native_right);
			}
		}

		static Delegate cb_toString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToString_Ljava_lang_String_Handler ()
		{
			if (cb_toString_Ljava_lang_String_ == null)
				cb_toString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ToString_Ljava_lang_String_);
			return cb_toString_Ljava_lang_String_;
		}

		static IntPtr n_ToString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.Triple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToString (format));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/String;)Ljava/lang/String;", "GetToString_Ljava_lang_String_Handler")]
		public virtual unsafe string ToString (string format)
		{
			if (id_toString_Ljava_lang_String_ == IntPtr.Zero)
				id_toString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_format);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.Triple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (o);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public abstract global::System.Int32 CompareTo (global::Java.Lang.Object o);

	}

	[global::Android.Runtime.Register ("org/apache/commons/lang3/tuple/Triple", DoNotGenerateAcw=true)]
	internal partial class TripleInvoker : Triple {

		public TripleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TripleInvoker); }
		}

		static IntPtr id_getLeft;
		protected override unsafe global::Java.Lang.Object RawLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='getLeft' and count(parameter)=0]"
			[Register ("getLeft", "()Ljava/lang/Object;", "GetGetLeftHandler")]
			get {
				if (id_getLeft == IntPtr.Zero)
					id_getLeft = JNIEnv.GetMethodID (class_ref, "getLeft", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLeft), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMiddle;
		protected override unsafe global::Java.Lang.Object RawMiddle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='getMiddle' and count(parameter)=0]"
			[Register ("getMiddle", "()Ljava/lang/Object;", "GetGetMiddleHandler")]
			get {
				if (id_getMiddle == IntPtr.Zero)
					id_getMiddle = JNIEnv.GetMethodID (class_ref, "getMiddle", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiddle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRight;
		protected override unsafe global::Java.Lang.Object RawRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='Triple']/method[@name='getRight' and count(parameter)=0]"
			[Register ("getRight", "()Ljava/lang/Object;", "GetGetRightHandler")]
			get {
				if (id_getRight == IntPtr.Zero)
					id_getRight = JNIEnv.GetMethodID (class_ref, "getRight", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRight), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_compareTo_Ljava_lang_Object_;
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public override unsafe global::System.Int32 CompareTo (global::Java.Lang.Object o)
		{
			if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
