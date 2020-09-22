using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Tuple {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/tuple/MutableTriple", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"L", "M", "R"})]
	public partial class MutableTriple : global::Org.Apache.Commons.Lang3.Tuple.Triple {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/tuple/MutableTriple", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MutableTriple); }
		}

		protected MutableTriple (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/constructor[@name='MutableTriple' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MutableTriple ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MutableTriple)) {
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

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/constructor[@name='MutableTriple' and count(parameter)=3 and parameter[1][@type='L'] and parameter[2][@type='M'] and parameter[3][@type='R']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe MutableTriple (global::Java.Lang.Object left, global::Java.Lang.Object middle, global::Java.Lang.Object right)
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
				if (((object) this).GetType () != typeof (MutableTriple)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.MutableTriple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Left);
		}
#pragma warning restore 0169

		static Delegate cb_setLeft_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetLeft_Ljava_lang_Object_Handler ()
		{
			if (cb_setLeft_Ljava_lang_Object_ == null)
				cb_setLeft_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLeft_Ljava_lang_Object_);
			return cb_setLeft_Ljava_lang_Object_;
		}

		static void n_SetLeft_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_left)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.MutableTriple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var left = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_left, JniHandleOwnership.DoNotTransfer);
			__this.Left = left;
		}
#pragma warning restore 0169

		static IntPtr id_getLeft;
		static IntPtr id_setLeft_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object Left {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/method[@name='getLeft' and count(parameter)=0]"
			[Register ("getLeft", "()Ljava/lang/Object;", "GetGetLeftHandler")]
			get {
				if (id_getLeft == IntPtr.Zero)
					id_getLeft = JNIEnv.GetMethodID (class_ref, "getLeft", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLeft), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeft", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/method[@name='setLeft' and count(parameter)=1 and parameter[1][@type='L']]"
			[Register ("setLeft", "(Ljava/lang/Object;)V", "GetSetLeft_Ljava_lang_Object_Handler")]
			set {
				if (id_setLeft_Ljava_lang_Object_ == IntPtr.Zero)
					id_setLeft_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setLeft", "(Ljava/lang/Object;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLeft_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLeft", "(Ljava/lang/Object;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.MutableTriple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Middle);
		}
#pragma warning restore 0169

		static Delegate cb_setMiddle_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetMiddle_Ljava_lang_Object_Handler ()
		{
			if (cb_setMiddle_Ljava_lang_Object_ == null)
				cb_setMiddle_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMiddle_Ljava_lang_Object_);
			return cb_setMiddle_Ljava_lang_Object_;
		}

		static void n_SetMiddle_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_middle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.MutableTriple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var middle = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_middle, JniHandleOwnership.DoNotTransfer);
			__this.Middle = middle;
		}
#pragma warning restore 0169

		static IntPtr id_getMiddle;
		static IntPtr id_setMiddle_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object Middle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/method[@name='getMiddle' and count(parameter)=0]"
			[Register ("getMiddle", "()Ljava/lang/Object;", "GetGetMiddleHandler")]
			get {
				if (id_getMiddle == IntPtr.Zero)
					id_getMiddle = JNIEnv.GetMethodID (class_ref, "getMiddle", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiddle), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiddle", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/method[@name='setMiddle' and count(parameter)=1 and parameter[1][@type='M']]"
			[Register ("setMiddle", "(Ljava/lang/Object;)V", "GetSetMiddle_Ljava_lang_Object_Handler")]
			set {
				if (id_setMiddle_Ljava_lang_Object_ == IntPtr.Zero)
					id_setMiddle_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setMiddle", "(Ljava/lang/Object;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMiddle_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMiddle", "(Ljava/lang/Object;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.MutableTriple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Right);
		}
#pragma warning restore 0169

		static Delegate cb_setRight_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetRight_Ljava_lang_Object_Handler ()
		{
			if (cb_setRight_Ljava_lang_Object_ == null)
				cb_setRight_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRight_Ljava_lang_Object_);
			return cb_setRight_Ljava_lang_Object_;
		}

		static void n_SetRight_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_right)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.MutableTriple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var right = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_right, JniHandleOwnership.DoNotTransfer);
			__this.Right = right;
		}
#pragma warning restore 0169

		static IntPtr id_getRight;
		static IntPtr id_setRight_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object Right {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/method[@name='getRight' and count(parameter)=0]"
			[Register ("getRight", "()Ljava/lang/Object;", "GetGetRightHandler")]
			get {
				if (id_getRight == IntPtr.Zero)
					id_getRight = JNIEnv.GetMethodID (class_ref, "getRight", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRight), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRight", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/method[@name='setRight' and count(parameter)=1 and parameter[1][@type='R']]"
			[Register ("setRight", "(Ljava/lang/Object;)V", "GetSetRight_Ljava_lang_Object_Handler")]
			set {
				if (id_setRight_Ljava_lang_Object_ == IntPtr.Zero)
					id_setRight_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setRight", "(Ljava/lang/Object;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRight_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRight", "(Ljava/lang/Object;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.tuple']/class[@name='MutableTriple']/method[@name='of' and count(parameter)=3 and parameter[1][@type='L'] and parameter[2][@type='M'] and parameter[3][@type='R']]"
		[Register ("of", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/MutableTriple;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"L", "M", "R"})]
		public static unsafe global::Org.Apache.Commons.Lang3.Tuple.MutableTriple Of (global::Java.Lang.Object left, global::Java.Lang.Object middle, global::Java.Lang.Object right)
		{
			if (id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "of", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Lorg/apache/commons/lang3/tuple/MutableTriple;");
			IntPtr native_left = JNIEnv.ToLocalJniHandle (left);
			IntPtr native_middle = JNIEnv.ToLocalJniHandle (middle);
			IntPtr native_right = JNIEnv.ToLocalJniHandle (right);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_left);
				__args [1] = new JValue (native_middle);
				__args [2] = new JValue (native_right);
				global::Org.Apache.Commons.Lang3.Tuple.MutableTriple __ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Tuple.MutableTriple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_left);
				JNIEnv.DeleteLocalRef (native_middle);
				JNIEnv.DeleteLocalRef (native_right);
			}
		}

	}
}
