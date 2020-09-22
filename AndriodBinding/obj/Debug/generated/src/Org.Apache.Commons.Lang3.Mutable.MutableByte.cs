using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Mutable {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/mutable/MutableByte", DoNotGenerateAcw=true)]
	public partial class MutableByte : global::Java.Lang.Number, global::Java.Lang.IComparable, global::Org.Apache.Commons.Lang3.Mutable.IMutable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/mutable/MutableByte", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MutableByte); }
		}

		protected MutableByte (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/constructor[@name='MutableByte' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MutableByte ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MutableByte)) {
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

		static IntPtr id_ctor_B;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/constructor[@name='MutableByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register (".ctor", "(B)V", "")]
		public unsafe MutableByte (sbyte value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MutableByte)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(B)V", __args);
					return;
				}

				if (id_ctor_B == IntPtr.Zero)
					id_ctor_B = JNIEnv.GetMethodID (class_ref, "<init>", "(B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_B, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_B, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Number_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/constructor[@name='MutableByte' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register (".ctor", "(Ljava/lang/Number;)V", "")]
		public unsafe MutableByte (global::Java.Lang.Number value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				if (((object) this).GetType () != typeof (MutableByte)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/constructor[@name='MutableByte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MutableByte (string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				if (((object) this).GetType () != typeof (MutableByte)) {
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
				cb_getAndDecrement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_B) n_GetAndDecrement);
			return cb_getAndDecrement;
		}

		static sbyte n_GetAndDecrement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AndDecrement;
		}
#pragma warning restore 0169

		static IntPtr id_getAndDecrement;
		public virtual unsafe sbyte AndDecrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='getAndDecrement' and count(parameter)=0]"
			[Register ("getAndDecrement", "()B", "GetGetAndDecrementHandler")]
			get {
				if (id_getAndDecrement == IntPtr.Zero)
					id_getAndDecrement = JNIEnv.GetMethodID (class_ref, "getAndDecrement", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getAndDecrement);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndDecrement", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getAndIncrement;
#pragma warning disable 0169
		static Delegate GetGetAndIncrementHandler ()
		{
			if (cb_getAndIncrement == null)
				cb_getAndIncrement = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_B) n_GetAndIncrement);
			return cb_getAndIncrement;
		}

		static sbyte n_GetAndIncrement (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AndIncrement;
		}
#pragma warning restore 0169

		static IntPtr id_getAndIncrement;
		public virtual unsafe sbyte AndIncrement {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='getAndIncrement' and count(parameter)=0]"
			[Register ("getAndIncrement", "()B", "GetGetAndIncrementHandler")]
			get {
				if (id_getAndIncrement == IntPtr.Zero)
					id_getAndIncrement = JNIEnv.GetMethodID (class_ref, "getAndIncrement", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getAndIncrement);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndIncrement", "()B"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe global::Java.Lang.Byte Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Byte;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Byte;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Byte;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_B;
#pragma warning disable 0169
		static Delegate GetAdd_BHandler ()
		{
			if (cb_add_B == null)
				cb_add_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_V) n_Add_B);
			return cb_add_B;
		}

		static void n_Add_B (IntPtr jnienv, IntPtr native__this, sbyte operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (operand);
		}
#pragma warning restore 0169

		static IntPtr id_add_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='add' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("add", "(B)V", "GetAdd_BHandler")]
		public virtual unsafe void Add (sbyte operand)
		{
			if (id_add_B == IntPtr.Zero)
				id_add_B = JNIEnv.GetMethodID (class_ref, "add", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_B, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(B)V"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			__this.Add (operand);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
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

		static Delegate cb_addAndGet_B;
#pragma warning disable 0169
		static Delegate GetAddAndGet_BHandler ()
		{
			if (cb_addAndGet_B == null)
				cb_addAndGet_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_B) n_AddAndGet_B);
			return cb_addAndGet_B;
		}

		static sbyte n_AddAndGet_B (IntPtr jnienv, IntPtr native__this, sbyte operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AddAndGet (operand);
		}
#pragma warning restore 0169

		static IntPtr id_addAndGet_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='addAndGet' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("addAndGet", "(B)B", "GetAddAndGet_BHandler")]
		public virtual unsafe sbyte AddAndGet (sbyte operand)
		{
			if (id_addAndGet_B == IntPtr.Zero)
				id_addAndGet_B = JNIEnv.GetMethodID (class_ref, "addAndGet", "(B)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_addAndGet_B, __args);
				else
					return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAndGet", "(B)B"), __args);
			} finally {
			}
		}

		static Delegate cb_addAndGet_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetAddAndGet_Ljava_lang_Number_Handler ()
		{
			if (cb_addAndGet_Ljava_lang_Number_ == null)
				cb_addAndGet_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_B) n_AddAndGet_Ljava_lang_Number_);
			return cb_addAndGet_Ljava_lang_Number_;
		}

		static sbyte n_AddAndGet_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			sbyte __ret = __this.AddAndGet (operand);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAndGet_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='addAndGet' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("addAndGet", "(Ljava/lang/Number;)B", "GetAddAndGet_Ljava_lang_Number_Handler")]
		public virtual unsafe sbyte AddAndGet (global::Java.Lang.Number operand)
		{
			if (id_addAndGet_Ljava_lang_Number_ == IntPtr.Zero)
				id_addAndGet_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addAndGet", "(Ljava/lang/Number;)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				sbyte __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_addAndGet_Ljava_lang_Number_, __args);
				else
					__ret = JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAndGet", "(Ljava/lang/Number;)B"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableByte_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lorg_apache_commons_lang3_mutable_MutableByte_Handler ()
		{
			if (cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableByte_ == null)
				cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableByte_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Lorg_apache_commons_lang3_mutable_MutableByte_);
			return cb_compareTo_Lorg_apache_commons_lang3_mutable_MutableByte_;
		}

		static int n_CompareTo_Lorg_apache_commons_lang3_mutable_MutableByte_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (native_other, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lorg_apache_commons_lang3_mutable_MutableByte_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='org.apache.commons.lang3.mutable.MutableByte']]"
		[Register ("compareTo", "(Lorg/apache/commons/lang3/mutable/MutableByte;)I", "GetCompareTo_Lorg_apache_commons_lang3_mutable_MutableByte_Handler")]
		public virtual unsafe int CompareTo (global::Org.Apache.Commons.Lang3.Mutable.MutableByte other)
		{
			if (id_compareTo_Lorg_apache_commons_lang3_mutable_MutableByte_ == IntPtr.Zero)
				id_compareTo_Lorg_apache_commons_lang3_mutable_MutableByte_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lorg/apache/commons/lang3/mutable/MutableByte;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lorg_apache_commons_lang3_mutable_MutableByte_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lorg/apache/commons/lang3/mutable/MutableByte;)I"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Decrement ();
		}
#pragma warning restore 0169

		static IntPtr id_decrement;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='decrement' and count(parameter)=0]"
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
				cb_decrementAndGet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_B) n_DecrementAndGet);
			return cb_decrementAndGet;
		}

		static sbyte n_DecrementAndGet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecrementAndGet ();
		}
#pragma warning restore 0169

		static IntPtr id_decrementAndGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='decrementAndGet' and count(parameter)=0]"
		[Register ("decrementAndGet", "()B", "GetDecrementAndGetHandler")]
		public virtual unsafe sbyte DecrementAndGet ()
		{
			if (id_decrementAndGet == IntPtr.Zero)
				id_decrementAndGet = JNIEnv.GetMethodID (class_ref, "decrementAndGet", "()B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_decrementAndGet);
				else
					return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrementAndGet", "()B"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoubleValue ();
		}
#pragma warning restore 0169

		static IntPtr id_doubleValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='doubleValue' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FloatValue ();
		}
#pragma warning restore 0169

		static IntPtr id_floatValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='floatValue' and count(parameter)=0]"
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

		static Delegate cb_getAndAdd_B;
#pragma warning disable 0169
		static Delegate GetGetAndAdd_BHandler ()
		{
			if (cb_getAndAdd_B == null)
				cb_getAndAdd_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_B) n_GetAndAdd_B);
			return cb_getAndAdd_B;
		}

		static sbyte n_GetAndAdd_B (IntPtr jnienv, IntPtr native__this, sbyte operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAndAdd (operand);
		}
#pragma warning restore 0169

		static IntPtr id_getAndAdd_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='getAndAdd' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getAndAdd", "(B)B", "GetGetAndAdd_BHandler")]
		public virtual unsafe sbyte GetAndAdd (sbyte operand)
		{
			if (id_getAndAdd_B == IntPtr.Zero)
				id_getAndAdd_B = JNIEnv.GetMethodID (class_ref, "getAndAdd", "(B)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getAndAdd_B, __args);
				else
					return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndAdd", "(B)B"), __args);
			} finally {
			}
		}

		static Delegate cb_getAndAdd_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetGetAndAdd_Ljava_lang_Number_Handler ()
		{
			if (cb_getAndAdd_Ljava_lang_Number_ == null)
				cb_getAndAdd_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_B) n_GetAndAdd_Ljava_lang_Number_);
			return cb_getAndAdd_Ljava_lang_Number_;
		}

		static sbyte n_GetAndAdd_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			sbyte __ret = __this.GetAndAdd (operand);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAndAdd_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='getAndAdd' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("getAndAdd", "(Ljava/lang/Number;)B", "GetGetAndAdd_Ljava_lang_Number_Handler")]
		public virtual unsafe sbyte GetAndAdd (global::Java.Lang.Number operand)
		{
			if (id_getAndAdd_Ljava_lang_Number_ == IntPtr.Zero)
				id_getAndAdd_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "getAndAdd", "(Ljava/lang/Number;)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				sbyte __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getAndAdd_Ljava_lang_Number_, __args);
				else
					__ret = JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAndAdd", "(Ljava/lang/Number;)B"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Increment ();
		}
#pragma warning restore 0169

		static IntPtr id_increment;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='increment' and count(parameter)=0]"
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
				cb_incrementAndGet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_B) n_IncrementAndGet);
			return cb_incrementAndGet;
		}

		static sbyte n_IncrementAndGet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IncrementAndGet ();
		}
#pragma warning restore 0169

		static IntPtr id_incrementAndGet;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='incrementAndGet' and count(parameter)=0]"
		[Register ("incrementAndGet", "()B", "GetIncrementAndGetHandler")]
		public virtual unsafe sbyte IncrementAndGet ()
		{
			if (id_incrementAndGet == IntPtr.Zero)
				id_incrementAndGet = JNIEnv.GetMethodID (class_ref, "incrementAndGet", "()B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_incrementAndGet);
				else
					return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "incrementAndGet", "()B"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IntValue ();
		}
#pragma warning restore 0169

		static IntPtr id_intValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='intValue' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongValue ();
		}
#pragma warning restore 0169

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='longValue' and count(parameter)=0]"
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

		static Delegate cb_setValue_B;
#pragma warning disable 0169
		static Delegate GetSetValue_BHandler ()
		{
			if (cb_setValue_B == null)
				cb_setValue_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_V) n_SetValue_B);
			return cb_setValue_B;
		}

		static void n_SetValue_B (IntPtr jnienv, IntPtr native__this, sbyte value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (value);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("setValue", "(B)V", "GetSetValue_BHandler")]
		public virtual unsafe void SetValue (sbyte value)
		{
			if (id_setValue_B == IntPtr.Zero)
				id_setValue_B = JNIEnv.GetMethodID (class_ref, "setValue", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_B, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(B)V"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (value);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
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

		static Delegate cb_subtract_B;
#pragma warning disable 0169
		static Delegate GetSubtract_BHandler ()
		{
			if (cb_subtract_B == null)
				cb_subtract_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_V) n_Subtract_B);
			return cb_subtract_B;
		}

		static void n_Subtract_B (IntPtr jnienv, IntPtr native__this, sbyte operand)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Subtract (operand);
		}
#pragma warning restore 0169

		static IntPtr id_subtract_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("subtract", "(B)V", "GetSubtract_BHandler")]
		public virtual unsafe void Subtract (sbyte operand)
		{
			if (id_subtract_B == IntPtr.Zero)
				id_subtract_B = JNIEnv.GetMethodID (class_ref, "subtract", "(B)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (operand);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subtract_B, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subtract", "(B)V"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var operand = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_operand, JniHandleOwnership.DoNotTransfer);
			__this.Subtract (operand);
		}
#pragma warning restore 0169

		static IntPtr id_subtract_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
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

		static Delegate cb_toByte;
#pragma warning disable 0169
		static Delegate GetToByteHandler ()
		{
			if (cb_toByte == null)
				cb_toByte = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToByte);
			return cb_toByte;
		}

		static IntPtr n_ToByte (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Mutable.MutableByte> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToByte ());
		}
#pragma warning restore 0169

		static IntPtr id_toByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.mutable']/class[@name='MutableByte']/method[@name='toByte' and count(parameter)=0]"
		[Register ("toByte", "()Ljava/lang/Byte;", "GetToByteHandler")]
		public virtual unsafe global::Java.Lang.Byte ToByte ()
		{
			if (id_toByte == IntPtr.Zero)
				id_toByte = JNIEnv.GetMethodID (class_ref, "toByte", "()Ljava/lang/Byte;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByte), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByte", "()Ljava/lang/Byte;")), JniHandleOwnership.TransferLocalRef);
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
