using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Tuple {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutableTriple']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/tuple/ImmutableTriple", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L", "M", "R"})]
	public sealed partial class ImmutableTriple : global::Org.Apache.Commons.Lang3.Tuple.Triple {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/tuple/ImmutableTriple", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImmutableTriple); }
		}

		internal ImmutableTriple (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutableTriple']/constructor[@name='ImmutableTriple' and count(parameter)=3 and parameter[1][@type='L'] and parameter[2][@type='M'] and parameter[3][@type='R']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe ImmutableTriple (global::Java.Lang.Object left, global::Java.Lang.Object middle, global::Java.Lang.Object right)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_left = JNIEnv.ToLocalJniHandle (left);
			IntPtr native_middle = JNIEnv.ToLocalJniHandle (middle);
			IntPtr native_right = JNIEnv.ToLocalJniHandle (right);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_left);
				__args [1] = new JValue (native_middle);
				__args [2] = new JValue (native_right);
				if (((object) this).GetType () != typeof (ImmutableTriple)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_left);
				JNIEnv.DeleteLocalRef (native_middle);
				JNIEnv.DeleteLocalRef (native_right);
			}
		}

		static IntPtr id_getLeft;
		public unsafe global::Java.Lang.Object Left {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutableTriple']/method[@name='getLeft' and count(parameter)=0]"
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

		static IntPtr id_getMiddle;
		public unsafe global::Java.Lang.Object Middle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutableTriple']/method[@name='getMiddle' and count(parameter)=0]"
			[Register ("getMiddle", "()Ljava/lang/Object;", "")]
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
		public unsafe global::Java.Lang.Object Right {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutableTriple']/method[@name='getRight' and count(parameter)=0]"
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

		static IntPtr id_nullTriple;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutableTriple']/method[@name='nullTriple' and count(parameter)=0]"
		[Register ("nullTriple", "()Lorg/apache/commons/lang3/tuple/ImmutableTriple;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"L", "M", "R"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Tuple.ImmutableTriple NullTriple ()
		{
			if (id_nullTriple == IntPtr.Zero)
				id_nullTriple = JNIEnv.GetStaticMethodID (class_ref, "nullTriple", "()Lorg/apache/commons/lang3/tuple/ImmutableTriple;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.ImmutableTriple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_nullTriple), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='ImmutableTriple']/method[@name='of' and count(parameter)=3 and parameter[1][@type='L'] and parameter[2][@type='M'] and parameter[3][@type='R']]"
		[Register ("of", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutableTriple;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"L", "M", "R"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Tuple.ImmutableTriple Of (global::Java.Lang.Object left, global::Java.Lang.Object middle, global::Java.Lang.Object right)
		{
			if (id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "of", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/ImmutableTriple;");
			IntPtr native_left = JNIEnv.ToLocalJniHandle (left);
			IntPtr native_middle = JNIEnv.ToLocalJniHandle (middle);
			IntPtr native_right = JNIEnv.ToLocalJniHandle (right);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_left);
				__args [1] = new JValue (native_middle);
				__args [2] = new JValue (native_right);
				global::Org.Apache.Commons.Lang3.Tuple.ImmutableTriple __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.ImmutableTriple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_left);
				JNIEnv.DeleteLocalRef (native_middle);
				JNIEnv.DeleteLocalRef (native_right);
			}
		}

	}
}
