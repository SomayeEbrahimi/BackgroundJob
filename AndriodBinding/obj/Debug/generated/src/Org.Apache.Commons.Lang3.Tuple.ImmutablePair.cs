using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Tuple {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutablePair']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/tuple/ImmutablePair", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L", "R"})]
	public sealed partial class ImmutablePair : global::Org.Apache.Commons.Lang3.Tuple.Pair {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/tuple/ImmutablePair", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImmutablePair); }
		}

		internal ImmutablePair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutablePair']/constructor[@name='ImmutablePair' and count(parameter)=2 and parameter[1][@type='L'] and parameter[2][@type='R']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe ImmutablePair (global::Java.Lang.Object left, global::Java.Lang.Object right)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_left = JNIEnv.ToLocalJniHandle (left);
			IntPtr native_right = JNIEnv.ToLocalJniHandle (right);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_left);
				__args [1] = new JValue (native_right);
				if (((object) this).GetType () != typeof (ImmutablePair)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_left);
				JNIEnv.DeleteLocalRef (native_right);
			}
		}

		static IntPtr id_getLeft;
		public unsafe global::Java.Lang.Object Left {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutablePair']/method[@name='getLeft' and count(parameter)=0]"
			[Register ("getLeft", "()Ljava/lang/Object;", "")]
			get {
				if (id_getLeft == IntPtr.Zero)
					id_getLeft = JNIEnv.GetMethodID (class_ref, "getLeft", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLeft), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRight;
		public unsafe global::Java.Lang.Object Right {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutablePair']/method[@name='getRight' and count(parameter)=0]"
			[Register ("getRight", "()Ljava/lang/Object;", "")]
			get {
				if (id_getRight == IntPtr.Zero)
					id_getRight = JNIEnv.GetMethodID (class_ref, "getRight", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRight), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_nullPair;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutablePair']/method[@name='nullPair' and count(parameter)=0]"
		[Register ("nullPair", "()Lorg/apache/commons/lang3/tuple/ImmutablePair;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"L", "R"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Tuple.ImmutablePair NullPair ()
		{
			if (id_nullPair == IntPtr.Zero)
				id_nullPair = JNIEnv.GetStaticMethodID (class_ref, "nullPair", "()Lorg/apache/commons/lang3/tuple/ImmutablePair;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.ImmutablePair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullPair), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_of_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutablePair']/method[@name='of' and count(parameter)=2 and parameter[1][@type='L'] and parameter[2][@type='R']]"
		[Register ("of", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"L", "R"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Tuple.ImmutablePair Of (global::Java.Lang.Object left, global::Java.Lang.Object right)
		{
			if (id_of_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_of_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "of", "(Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutablePair;");
			IntPtr native_left = JNIEnv.ToLocalJniHandle (left);
			IntPtr native_right = JNIEnv.ToLocalJniHandle (right);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_left);
				__args [1] = new JValue (native_right);
				global::Org.Apache.Commons.Lang3.Tuple.ImmutablePair __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.ImmutablePair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_left);
				JNIEnv.DeleteLocalRef (native_right);
			}
		}

		static IntPtr id_setValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutablePair']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("setValue", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object SetValue (global::Java.Lang.Object value)
		{
			if (id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
