using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Mutable {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/mutable/MutableFloat", DoNotGenerateAcw=true)]
	public partial class MutableFloat : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/mutable/MutableFloat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MutableFloat); }
		}

		protected MutableFloat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/constructor[@name='MutableFloat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MutableFloat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MutableFloat)) {
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

		static IntPtr id_ctor_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/constructor[@name='MutableFloat' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe MutableFloat (float value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MutableFloat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(F)V", __args);
					return;
				}

				if (id_ctor_F == IntPtr.Zero)
					id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_F, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Number_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/constructor[@name='MutableFloat' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register (".ctor", "(Ljava/lang/Number;)V", "")]
		public unsafe MutableFloat (global::Java.Lang.Number value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MutableFloat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Number;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Number;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Number_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Number;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Number_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Number_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/constructor[@name='MutableFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MutableFloat (string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				if (((object) this).GetType () != typeof (MutableFloat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAndDecrement;
#pragma warning disable 0169
		static Delegate GetGetAndDecrementHandler ()
		{
			if (cb_getAndDecrement == null)
				cb_getAndDecrement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetAndDecrement);
			return cb_getAndDecrement;
		}

		static float n_GetAndDecrement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AndDecrement;
		}
#pragma warning restore 0169

		static IntPtr id_getAndDecrement;
		public virtual unsafe float AndDecrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='getAndDecrement' and count(parameter)=0]"
			[Register ("getAndDecrement", "()F", "GetGetAndDecrementHandler")]
			get {
				if (id_getAndDecrement == IntPtr.Zero)
					id_getAndDecrement = JNIEnv.GetMethodID (class_ref, "getAndDecrement", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAndDecrement);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndDecrement", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getAndIncrement;
#pragma warning disable 0169
		static Delegate GetGetAndIncrementHandler ()
		{
			if (cb_getAndIncrement == null)
				cb_getAndIncrement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetAndIncrement);
			return cb_getAndIncrement;
		}

		static float n_GetAndIncrement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AndIncrement;
		}
#pragma warning restore 0169

		static IntPtr id_getAndIncrement;
		public virtual unsafe float AndIncrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='getAndIncrement' and count(parameter)=0]"
			[Register ("getAndIncrement", "()F", "GetGetAndIncrementHandler")]
			get {
				if (id_getAndIncrement == IntPtr.Zero)
					id_getAndIncrement = JNIEnv.GetMethodID (class_ref, "getAndIncrement", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAndIncrement);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndIncrement", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_isInfinite;
#pragma warning disable 0169
		static Delegate GetIsInfiniteHandler ()
		{
			if (cb_isInfinite == null)
				cb_isInfinite = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInfinite);
			return cb_isInfinite;
		}

		static bool n_IsInfinite (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInfinite;
		}
#pragma warning restore 0169

		static IntPtr id_isInfinite;
		public virtual unsafe bool IsInfinite {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='isInfinite' and count(parameter)=0]"
			[Register ("isInfinite", "()Z", "GetIsInfiniteHandler")]
			get {
				if (id_isInfinite == IntPtr.Zero)
					id_isInfinite = JNIEnv.GetMethodID (class_ref, "isInfinite", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInfinite);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInfinite", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNaN;
#pragma warning disable 0169
		static Delegate GetIsNaNHandler ()
		{
			if (cb_isNaN == null)
				cb_isNaN = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNaN);
			return cb_isNaN;
		}

		static bool n_IsNaN (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNaN;
		}
#pragma warning restore 0169

		static IntPtr id_isNaN;
		public virtual unsafe bool IsNaN {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='isNaN' and count(parameter)=0]"
			[Register ("isNaN", "()Z", "GetIsNaNHandler")]
			get {
				if (id_isNaN == IntPtr.Zero)
					id_isNaN = JNIEnv.GetMethodID (class_ref, "isNaN", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNaN);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNaN", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe global::Java.Lang.Float Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Float;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Float;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Float;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_F;
#pragma warning disable 0169
		static Delegate GetAdd_FHandler ()
		{
			if (cb_add_F == null)
				cb_add_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_Add_F);
			return cb_add_F;
		}

		static void n_Add_F (IntPtr jnienv, IntPtr native__this, float operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (operand);
		}
#pragma warning restore 0169

		static IntPtr id_add_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='add' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("add", "(F)V", "GetAdd_FHandler")]
		public virtual unsafe void Add (float operand)
		{
			if (id_add_F == IntPtr.Zero)
				id_add_F = JNIEnv.GetMethodID (class_ref, "add", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_add_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Number_Handler ()
		{
			if (cb_add_Ljava_lang_Number_ == null)
				cb_add_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Add_Ljava_lang_Number_);
			return cb_add_Ljava_lang_Number_;
		}

		static void n_Add_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			__this.Add (operand);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("add", "(Ljava/lang/Number;)V", "GetAdd_Ljava_lang_Number_Handler")]
		public virtual unsafe void Add (global::Java.Lang.Number operand)
		{
			if (id_add_Ljava_lang_Number_ == IntPtr.Zero)
				id_add_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Number;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Number_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/Number;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addAndGet_F;
#pragma warning disable 0169
		static Delegate GetAddAndGet_FHandler ()
		{
			if (cb_addAndGet_F == null)
				cb_addAndGet_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_F) n_AddAndGet_F);
			return cb_addAndGet_F;
		}

		static float n_AddAndGet_F (IntPtr jnienv, IntPtr native__this, float operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AddAndGet (operand);
		}
#pragma warning restore 0169

		static IntPtr id_addAndGet_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='addAndGet' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("addAndGet", "(F)F", "GetAddAndGet_FHandler")]
		public virtual unsafe float AddAndGet (float operand)
		{
			if (id_addAndGet_F == IntPtr.Zero)
				id_addAndGet_F = JNIEnv.GetMethodID (class_ref, "addAndGet", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_addAndGet_F, __args);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAndGet", "(F)F"), __args);
			} finally {
			}
		}

		static Delegate cb_addAndGet_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAddAndGet_Ljava_lang_Number_Handler ()
		{
			if (cb_addAndGet_Ljava_lang_Number_ == null)
				cb_addAndGet_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_AddAndGet_Ljava_lang_Number_);
			return cb_addAndGet_Ljava_lang_Number_;
		}

		static float n_AddAndGet_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.AddAndGet (operand);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAndGet_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='addAndGet' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("addAndGet", "(Ljava/lang/Number;)F", "GetAddAndGet_Ljava_lang_Number_Handler")]
		public virtual unsafe float AddAndGet (global::Java.Lang.Number operand)
		{
			if (id_addAndGet_Ljava_lang_Number_ == IntPtr.Zero)
				id_addAndGet_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addAndGet", "(Ljava/lang/Number;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				float __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_addAndGet_Ljava_lang_Number_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAndGet", "(Ljava/lang/Number;)F"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_Handler ()
		{
			if (cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_ == null)
				cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_);
			return cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_;
		}

		static int n_CompareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (native_other, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.mutable.MutableFloat']]"
		[Register ("compareTo", "(Lorg/apache/commons/lang3/mutable/MutableFloat;)I", "GetCompareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_Handler")]
		public virtual unsafe int CompareTo (global::Org.Apache.Commons.Lang3.Mutable.MutableFloat other)
		{
			if (id_compareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_ == IntPtr.Zero)
				id_compareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lorg/apache/commons/lang3/mutable/MutableFloat;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lorg_apache_commons_lang3_mutable_MutableFloat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lorg/apache/commons/lang3/mutable/MutableFloat;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_decrement;
#pragma warning disable 0169
		static Delegate GetDecrementHandler ()
		{
			if (cb_decrement == null)
				cb_decrement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Decrement);
			return cb_decrement;
		}

		static void n_Decrement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement ();
		}
#pragma warning restore 0169

		static IntPtr id_decrement;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='decrement' and count(parameter)=0]"
		[Register ("decrement", "()V", "GetDecrementHandler")]
		public virtual unsafe void Decrement ()
		{
			if (id_decrement == IntPtr.Zero)
				id_decrement = JNIEnv.GetMethodID (class_ref, "decrement", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decrement);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrement", "()V"));
			} finally {
			}
		}

		static Delegate cb_decrementAndGet;
#pragma warning disable 0169
		static Delegate GetDecrementAndGetHandler ()
		{
			if (cb_decrementAndGet == null)
				cb_decrementAndGet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_DecrementAndGet);
			return cb_decrementAndGet;
		}

		static float n_DecrementAndGet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecrementAndGet ();
		}
#pragma warning restore 0169

		static IntPtr id_decrementAndGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='decrementAndGet' and count(parameter)=0]"
		[Register ("decrementAndGet", "()F", "GetDecrementAndGetHandler")]
		public virtual unsafe float DecrementAndGet ()
		{
			if (id_decrementAndGet == IntPtr.Zero)
				id_decrementAndGet = JNIEnv.GetMethodID (class_ref, "decrementAndGet", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_decrementAndGet);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrementAndGet", "()F"));
			} finally {
			}
		}

		static Delegate cb_doubleValue;
#pragma warning disable 0169
		static Delegate GetDoubleValueHandler ()
		{
			if (cb_doubleValue == null)
				cb_doubleValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_DoubleValue);
			return cb_doubleValue;
		}

		static double n_DoubleValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoubleValue ();
		}
#pragma warning restore 0169

		static IntPtr id_doubleValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='doubleValue' and count(parameter)=0]"
		[Register ("doubleValue", "()D", "GetDoubleValueHandler")]
		public override unsafe double DoubleValue ()
		{
			if (id_doubleValue == IntPtr.Zero)
				id_doubleValue = JNIEnv.GetMethodID (class_ref, "doubleValue", "()D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_doubleValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doubleValue", "()D"));
			} finally {
			}
		}

		static Delegate cb_floatValue;
#pragma warning disable 0169
		static Delegate GetFloatValueHandler ()
		{
			if (cb_floatValue == null)
				cb_floatValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_FloatValue);
			return cb_floatValue;
		}

		static float n_FloatValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FloatValue ();
		}
#pragma warning restore 0169

		static IntPtr id_floatValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='floatValue' and count(parameter)=0]"
		[Register ("floatValue", "()F", "GetFloatValueHandler")]
		public override unsafe float FloatValue ()
		{
			if (id_floatValue == IntPtr.Zero)
				id_floatValue = JNIEnv.GetMethodID (class_ref, "floatValue", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_floatValue);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "floatValue", "()F"));
			} finally {
			}
		}

		static Delegate cb_getAndAdd_F;
#pragma warning disable 0169
		static Delegate GetGetAndAdd_FHandler ()
		{
			if (cb_getAndAdd_F == null)
				cb_getAndAdd_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_F) n_GetAndAdd_F);
			return cb_getAndAdd_F;
		}

		static float n_GetAndAdd_F (IntPtr jnienv, IntPtr native__this, float operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAndAdd (operand);
		}
#pragma warning restore 0169

		static IntPtr id_getAndAdd_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='getAndAdd' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getAndAdd", "(F)F", "GetGetAndAdd_FHandler")]
		public virtual unsafe float GetAndAdd (float operand)
		{
			if (id_getAndAdd_F == IntPtr.Zero)
				id_getAndAdd_F = JNIEnv.GetMethodID (class_ref, "getAndAdd", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAndAdd_F, __args);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndAdd", "(F)F"), __args);
			} finally {
			}
		}

		static Delegate cb_getAndAdd_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetGetAndAdd_Ljava_lang_Number_Handler ()
		{
			if (cb_getAndAdd_Ljava_lang_Number_ == null)
				cb_getAndAdd_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetAndAdd_Ljava_lang_Number_);
			return cb_getAndAdd_Ljava_lang_Number_;
		}

		static float n_GetAndAdd_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetAndAdd (operand);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAndAdd_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='getAndAdd' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("getAndAdd", "(Ljava/lang/Number;)F", "GetGetAndAdd_Ljava_lang_Number_Handler")]
		public virtual unsafe float GetAndAdd (global::Java.Lang.Number operand)
		{
			if (id_getAndAdd_Ljava_lang_Number_ == IntPtr.Zero)
				id_getAndAdd_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "getAndAdd", "(Ljava/lang/Number;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				float __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAndAdd_Ljava_lang_Number_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndAdd", "(Ljava/lang/Number;)F"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_increment;
#pragma warning disable 0169
		static Delegate GetIncrementHandler ()
		{
			if (cb_increment == null)
				cb_increment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Increment);
			return cb_increment;
		}

		static void n_Increment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment ();
		}
#pragma warning restore 0169

		static IntPtr id_increment;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='increment' and count(parameter)=0]"
		[Register ("increment", "()V", "GetIncrementHandler")]
		public virtual unsafe void Increment ()
		{
			if (id_increment == IntPtr.Zero)
				id_increment = JNIEnv.GetMethodID (class_ref, "increment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_increment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increment", "()V"));
			} finally {
			}
		}

		static Delegate cb_incrementAndGet;
#pragma warning disable 0169
		static Delegate GetIncrementAndGetHandler ()
		{
			if (cb_incrementAndGet == null)
				cb_incrementAndGet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_IncrementAndGet);
			return cb_incrementAndGet;
		}

		static float n_IncrementAndGet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IncrementAndGet ();
		}
#pragma warning restore 0169

		static IntPtr id_incrementAndGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='incrementAndGet' and count(parameter)=0]"
		[Register ("incrementAndGet", "()F", "GetIncrementAndGetHandler")]
		public virtual unsafe float IncrementAndGet ()
		{
			if (id_incrementAndGet == IntPtr.Zero)
				id_incrementAndGet = JNIEnv.GetMethodID (class_ref, "incrementAndGet", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_incrementAndGet);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "incrementAndGet", "()F"));
			} finally {
			}
		}

		static Delegate cb_intValue;
#pragma warning disable 0169
		static Delegate GetIntValueHandler ()
		{
			if (cb_intValue == null)
				cb_intValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_IntValue);
			return cb_intValue;
		}

		static int n_IntValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IntValue ();
		}
#pragma warning restore 0169

		static IntPtr id_intValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='intValue' and count(parameter)=0]"
		[Register ("intValue", "()I", "GetIntValueHandler")]
		public override unsafe int IntValue ()
		{
			if (id_intValue == IntPtr.Zero)
				id_intValue = JNIEnv.GetMethodID (class_ref, "intValue", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_intValue);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "intValue", "()I"));
			} finally {
			}
		}

		static Delegate cb_longValue;
#pragma warning disable 0169
		static Delegate GetLongValueHandler ()
		{
			if (cb_longValue == null)
				cb_longValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_LongValue);
			return cb_longValue;
		}

		static long n_LongValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongValue ();
		}
#pragma warning restore 0169

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "GetLongValueHandler")]
		public override unsafe long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_longValue);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "longValue", "()J"));
			} finally {
			}
		}

		static Delegate cb_setValue_F;
#pragma warning disable 0169
		static Delegate GetSetValue_FHandler ()
		{
			if (cb_setValue_F == null)
				cb_setValue_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetValue_F);
			return cb_setValue_F;
		}

		static void n_SetValue_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (value);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setValue", "(F)V", "GetSetValue_FHandler")]
		public virtual unsafe void SetValue (float value)
		{
			if (id_setValue_F == IntPtr.Zero)
				id_setValue_F = JNIEnv.GetMethodID (class_ref, "setValue", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setValue_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_Number_Handler ()
		{
			if (cb_setValue_Ljava_lang_Number_ == null)
				cb_setValue_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValue_Ljava_lang_Number_);
			return cb_setValue_Ljava_lang_Number_;
		}

		static void n_SetValue_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (value);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("setValue", "(Ljava/lang/Number;)V", "GetSetValue_Ljava_lang_Number_Handler")]
		public virtual unsafe void SetValue (global::Java.Lang.Number value)
		{
			if (id_setValue_Ljava_lang_Number_ == IntPtr.Zero)
				id_setValue_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/Number;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_Number_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/Number;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_subtract_F;
#pragma warning disable 0169
		static Delegate GetSubtract_FHandler ()
		{
			if (cb_subtract_F == null)
				cb_subtract_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_Subtract_F);
			return cb_subtract_F;
		}

		static void n_Subtract_F (IntPtr jnienv, IntPtr native__this, float operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Subtract (operand);
		}
#pragma warning restore 0169

		static IntPtr id_subtract_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("subtract", "(F)V", "GetSubtract_FHandler")]
		public virtual unsafe void Subtract (float operand)
		{
			if (id_subtract_F == IntPtr.Zero)
				id_subtract_F = JNIEnv.GetMethodID (class_ref, "subtract", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subtract_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subtract", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_subtract_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetSubtract_Ljava_lang_Number_Handler ()
		{
			if (cb_subtract_Ljava_lang_Number_ == null)
				cb_subtract_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Subtract_Ljava_lang_Number_);
			return cb_subtract_Ljava_lang_Number_;
		}

		static void n_Subtract_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			__this.Subtract (operand);
		}
#pragma warning restore 0169

		static IntPtr id_subtract_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("subtract", "(Ljava/lang/Number;)V", "GetSubtract_Ljava_lang_Number_Handler")]
		public virtual unsafe void Subtract (global::Java.Lang.Number operand)
		{
			if (id_subtract_Ljava_lang_Number_ == IntPtr.Zero)
				id_subtract_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "subtract", "(Ljava/lang/Number;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subtract_Ljava_lang_Number_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subtract", "(Ljava/lang/Number;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toFloat;
#pragma warning disable 0169
		static Delegate GetToFloatHandler ()
		{
			if (cb_toFloat == null)
				cb_toFloat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToFloat);
			return cb_toFloat;
		}

		static IntPtr n_ToFloat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableFloat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToFloat ());
		}
#pragma warning restore 0169

		static IntPtr id_toFloat;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableFloat']/method[@name='toFloat' and count(parameter)=0]"
		[Register ("toFloat", "()Ljava/lang/Float;", "GetToFloatHandler")]
		public virtual unsafe global::Java.Lang.Float ToFloat ()
		{
			if (id_toFloat == IntPtr.Zero)
				id_toFloat = JNIEnv.GetMethodID (class_ref, "toFloat", "()Ljava/lang/Float;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toFloat), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toFloat", "()Ljava/lang/Float;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Org.Apache.Commons.Lang3.Mutable.IMutable
		global::Java.Lang.Object global::Org.Apache.Commons.Lang3.Mutable.IMutable.Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/interface[@name='Mutable']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler:Org.Apache.Commons.Lang3.Mutable.IMutableInvoker, AndriodBinding")] get {
				return Value;
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/interface[@name='Mutable']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("setValue", "(Ljava/lang/Object;)V", "GetSetValue_Ljava_lang_Object_Handler:Org.Apache.Commons.Lang3.Mutable.IMutableInvoker, AndriodBinding")] set {
				Value = global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Number>(value);
			}
		}

	}
}
