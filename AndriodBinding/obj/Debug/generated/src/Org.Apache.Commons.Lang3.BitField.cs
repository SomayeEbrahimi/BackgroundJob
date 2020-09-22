using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/BitField", DoNotGenerateAcw=true)]
	public partial class BitField : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/BitField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitField); }
		}

		protected BitField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/constructor[@name='BitField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BitField (int mask)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mask);
				if (((object) this).GetType () != typeof (BitField)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_clear_I;
#pragma warning disable 0169
		static Delegate GetClear_IHandler ()
		{
			if (cb_clear_I == null)
				cb_clear_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Clear_I);
			return cb_clear_I;
		}

		static int n_Clear_I (IntPtr jnienv, IntPtr native__this, int holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clear (holder);
		}
#pragma warning restore 0169

		static IntPtr id_clear_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clear", "(I)I", "GetClear_IHandler")]
		public virtual unsafe int Clear (int holder)
		{
			if (id_clear_I == IntPtr.Zero)
				id_clear_I = JNIEnv.GetMethodID (class_ref, "clear", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_clear_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_clearByte_B;
#pragma warning disable 0169
		static Delegate GetClearByte_BHandler ()
		{
			if (cb_clearByte_B == null)
				cb_clearByte_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_B) n_ClearByte_B);
			return cb_clearByte_B;
		}

		static sbyte n_ClearByte_B (IntPtr jnienv, IntPtr native__this, sbyte holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearByte (holder);
		}
#pragma warning restore 0169

		static IntPtr id_clearByte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='clearByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("clearByte", "(B)B", "GetClearByte_BHandler")]
		public virtual unsafe sbyte ClearByte (sbyte holder)
		{
			if (id_clearByte_B == IntPtr.Zero)
				id_clearByte_B = JNIEnv.GetMethodID (class_ref, "clearByte", "(B)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_clearByte_B, __args);
				else
					return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearByte", "(B)B"), __args);
			} finally {
			}
		}

		static Delegate cb_clearShort_S;
#pragma warning disable 0169
		static Delegate GetClearShort_SHandler ()
		{
			if (cb_clearShort_S == null)
				cb_clearShort_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPS_S) n_ClearShort_S);
			return cb_clearShort_S;
		}

		static short n_ClearShort_S (IntPtr jnienv, IntPtr native__this, short holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearShort (holder);
		}
#pragma warning restore 0169

		static IntPtr id_clearShort_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='clearShort' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("clearShort", "(S)S", "GetClearShort_SHandler")]
		public virtual unsafe short ClearShort (short holder)
		{
			if (id_clearShort_S == IntPtr.Zero)
				id_clearShort_S = JNIEnv.GetMethodID (class_ref, "clearShort", "(S)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_clearShort_S, __args);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearShort", "(S)S"), __args);
			} finally {
			}
		}

		static Delegate cb_getRawValue_I;
#pragma warning disable 0169
		static Delegate GetGetRawValue_IHandler ()
		{
			if (cb_getRawValue_I == null)
				cb_getRawValue_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRawValue_I);
			return cb_getRawValue_I;
		}

		static int n_GetRawValue_I (IntPtr jnienv, IntPtr native__this, int holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRawValue (holder);
		}
#pragma warning restore 0169

		static IntPtr id_getRawValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='getRawValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRawValue", "(I)I", "GetGetRawValue_IHandler")]
		public virtual unsafe int GetRawValue (int holder)
		{
			if (id_getRawValue_I == IntPtr.Zero)
				id_getRawValue_I = JNIEnv.GetMethodID (class_ref, "getRawValue", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRawValue_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawValue", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getShortRawValue_S;
#pragma warning disable 0169
		static Delegate GetGetShortRawValue_SHandler ()
		{
			if (cb_getShortRawValue_S == null)
				cb_getShortRawValue_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPS_S) n_GetShortRawValue_S);
			return cb_getShortRawValue_S;
		}

		static short n_GetShortRawValue_S (IntPtr jnienv, IntPtr native__this, short holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetShortRawValue (holder);
		}
#pragma warning restore 0169

		static IntPtr id_getShortRawValue_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='getShortRawValue' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("getShortRawValue", "(S)S", "GetGetShortRawValue_SHandler")]
		public virtual unsafe short GetShortRawValue (short holder)
		{
			if (id_getShortRawValue_S == IntPtr.Zero)
				id_getShortRawValue_S = JNIEnv.GetMethodID (class_ref, "getShortRawValue", "(S)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getShortRawValue_S, __args);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortRawValue", "(S)S"), __args);
			} finally {
			}
		}

		static Delegate cb_getShortValue_S;
#pragma warning disable 0169
		static Delegate GetGetShortValue_SHandler ()
		{
			if (cb_getShortValue_S == null)
				cb_getShortValue_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPS_S) n_GetShortValue_S);
			return cb_getShortValue_S;
		}

		static short n_GetShortValue_S (IntPtr jnienv, IntPtr native__this, short holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetShortValue (holder);
		}
#pragma warning restore 0169

		static IntPtr id_getShortValue_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='getShortValue' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("getShortValue", "(S)S", "GetGetShortValue_SHandler")]
		public virtual unsafe short GetShortValue (short holder)
		{
			if (id_getShortValue_S == IntPtr.Zero)
				id_getShortValue_S = JNIEnv.GetMethodID (class_ref, "getShortValue", "(S)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getShortValue_S, __args);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortValue", "(S)S"), __args);
			} finally {
			}
		}

		static Delegate cb_getValue_I;
#pragma warning disable 0169
		static Delegate GetGetValue_IHandler ()
		{
			if (cb_getValue_I == null)
				cb_getValue_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetValue_I);
			return cb_getValue_I;
		}

		static int n_GetValue_I (IntPtr jnienv, IntPtr native__this, int holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetValue (holder);
		}
#pragma warning restore 0169

		static IntPtr id_getValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValue", "(I)I", "GetGetValue_IHandler")]
		public virtual unsafe int GetValue (int holder)
		{
			if (id_getValue_I == IntPtr.Zero)
				id_getValue_I = JNIEnv.GetMethodID (class_ref, "getValue", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_isAllSet_I;
#pragma warning disable 0169
		static Delegate GetIsAllSet_IHandler ()
		{
			if (cb_isAllSet_I == null)
				cb_isAllSet_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsAllSet_I);
			return cb_isAllSet_I;
		}

		static bool n_IsAllSet_I (IntPtr jnienv, IntPtr native__this, int holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAllSet (holder);
		}
#pragma warning restore 0169

		static IntPtr id_isAllSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='isAllSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAllSet", "(I)Z", "GetIsAllSet_IHandler")]
		public virtual unsafe bool IsAllSet (int holder)
		{
			if (id_isAllSet_I == IntPtr.Zero)
				id_isAllSet_I = JNIEnv.GetMethodID (class_ref, "isAllSet", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAllSet_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAllSet", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_isSet_I;
#pragma warning disable 0169
		static Delegate GetIsSet_IHandler ()
		{
			if (cb_isSet_I == null)
				cb_isSet_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsSet_I);
			return cb_isSet_I;
		}

		static bool n_IsSet_I (IntPtr jnienv, IntPtr native__this, int holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSet (holder);
		}
#pragma warning restore 0169

		static IntPtr id_isSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='isSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSet", "(I)Z", "GetIsSet_IHandler")]
		public virtual unsafe bool IsSet (int holder)
		{
			if (id_isSet_I == IntPtr.Zero)
				id_isSet_I = JNIEnv.GetMethodID (class_ref, "isSet", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSet_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSet", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_set_I;
#pragma warning disable 0169
		static Delegate GetSet_IHandler ()
		{
			if (cb_set_I == null)
				cb_set_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Set_I);
			return cb_set_I;
		}

		static int n_Set_I (IntPtr jnienv, IntPtr native__this, int holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Set (holder);
		}
#pragma warning restore 0169

		static IntPtr id_set_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='set' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set", "(I)I", "GetSet_IHandler")]
		public virtual unsafe int Set (int holder)
		{
			if (id_set_I == IntPtr.Zero)
				id_set_I = JNIEnv.GetMethodID (class_ref, "set", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_set_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_setBoolean_IZ;
#pragma warning disable 0169
		static Delegate GetSetBoolean_IZHandler ()
		{
			if (cb_setBoolean_IZ == null)
				cb_setBoolean_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_I) n_SetBoolean_IZ);
			return cb_setBoolean_IZ;
		}

		static int n_SetBoolean_IZ (IntPtr jnienv, IntPtr native__this, int holder, bool flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetBoolean (holder, flag);
		}
#pragma warning restore 0169

		static IntPtr id_setBoolean_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='setBoolean' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setBoolean", "(IZ)I", "GetSetBoolean_IZHandler")]
		public virtual unsafe int SetBoolean (int holder, bool flag)
		{
			if (id_setBoolean_IZ == IntPtr.Zero)
				id_setBoolean_IZ = JNIEnv.GetMethodID (class_ref, "setBoolean", "(IZ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (holder);
				__args [1] = new JValue (flag);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setBoolean_IZ, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBoolean", "(IZ)I"), __args);
			} finally {
			}
		}

		static Delegate cb_setByte_B;
#pragma warning disable 0169
		static Delegate GetSetByte_BHandler ()
		{
			if (cb_setByte_B == null)
				cb_setByte_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_B) n_SetByte_B);
			return cb_setByte_B;
		}

		static sbyte n_SetByte_B (IntPtr jnienv, IntPtr native__this, sbyte holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetByte (holder);
		}
#pragma warning restore 0169

		static IntPtr id_setByte_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='setByte' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("setByte", "(B)B", "GetSetByte_BHandler")]
		public virtual unsafe sbyte SetByte (sbyte holder)
		{
			if (id_setByte_B == IntPtr.Zero)
				id_setByte_B = JNIEnv.GetMethodID (class_ref, "setByte", "(B)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_setByte_B, __args);
				else
					return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setByte", "(B)B"), __args);
			} finally {
			}
		}

		static Delegate cb_setByteBoolean_BZ;
#pragma warning disable 0169
		static Delegate GetSetByteBoolean_BZHandler ()
		{
			if (cb_setByteBoolean_BZ == null)
				cb_setByteBoolean_BZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPBZ_B) n_SetByteBoolean_BZ);
			return cb_setByteBoolean_BZ;
		}

		static sbyte n_SetByteBoolean_BZ (IntPtr jnienv, IntPtr native__this, sbyte holder, bool flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetByteBoolean (holder, flag);
		}
#pragma warning restore 0169

		static IntPtr id_setByteBoolean_BZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='setByteBoolean' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='boolean']]"
		[Register ("setByteBoolean", "(BZ)B", "GetSetByteBoolean_BZHandler")]
		public virtual unsafe sbyte SetByteBoolean (sbyte holder, bool flag)
		{
			if (id_setByteBoolean_BZ == IntPtr.Zero)
				id_setByteBoolean_BZ = JNIEnv.GetMethodID (class_ref, "setByteBoolean", "(BZ)B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (holder);
				__args [1] = new JValue (flag);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_setByteBoolean_BZ, __args);
				else
					return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setByteBoolean", "(BZ)B"), __args);
			} finally {
			}
		}

		static Delegate cb_setShort_S;
#pragma warning disable 0169
		static Delegate GetSetShort_SHandler ()
		{
			if (cb_setShort_S == null)
				cb_setShort_S = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPS_S) n_SetShort_S);
			return cb_setShort_S;
		}

		static short n_SetShort_S (IntPtr jnienv, IntPtr native__this, short holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetShort (holder);
		}
#pragma warning restore 0169

		static IntPtr id_setShort_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='setShort' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setShort", "(S)S", "GetSetShort_SHandler")]
		public virtual unsafe short SetShort (short holder)
		{
			if (id_setShort_S == IntPtr.Zero)
				id_setShort_S = JNIEnv.GetMethodID (class_ref, "setShort", "(S)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_setShort_S, __args);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShort", "(S)S"), __args);
			} finally {
			}
		}

		static Delegate cb_setShortBoolean_SZ;
#pragma warning disable 0169
		static Delegate GetSetShortBoolean_SZHandler ()
		{
			if (cb_setShortBoolean_SZ == null)
				cb_setShortBoolean_SZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPSZ_S) n_SetShortBoolean_SZ);
			return cb_setShortBoolean_SZ;
		}

		static short n_SetShortBoolean_SZ (IntPtr jnienv, IntPtr native__this, short holder, bool flag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetShortBoolean (holder, flag);
		}
#pragma warning restore 0169

		static IntPtr id_setShortBoolean_SZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='setShortBoolean' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='boolean']]"
		[Register ("setShortBoolean", "(SZ)S", "GetSetShortBoolean_SZHandler")]
		public virtual unsafe short SetShortBoolean (short holder, bool flag)
		{
			if (id_setShortBoolean_SZ == IntPtr.Zero)
				id_setShortBoolean_SZ = JNIEnv.GetMethodID (class_ref, "setShortBoolean", "(SZ)S");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (holder);
				__args [1] = new JValue (flag);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_setShortBoolean_SZ, __args);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShortBoolean", "(SZ)S"), __args);
			} finally {
			}
		}

		static Delegate cb_setShortValue_SS;
#pragma warning disable 0169
		static Delegate GetSetShortValue_SSHandler ()
		{
			if (cb_setShortValue_SS == null)
				cb_setShortValue_SS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPSS_S) n_SetShortValue_SS);
			return cb_setShortValue_SS;
		}

		static short n_SetShortValue_SS (IntPtr jnienv, IntPtr native__this, short holder, short value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetShortValue (holder, value);
		}
#pragma warning restore 0169

		static IntPtr id_setShortValue_SS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='setShortValue' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("setShortValue", "(SS)S", "GetSetShortValue_SSHandler")]
		public virtual unsafe short SetShortValue (short holder, short value)
		{
			if (id_setShortValue_SS == IntPtr.Zero)
				id_setShortValue_SS = JNIEnv.GetMethodID (class_ref, "setShortValue", "(SS)S");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (holder);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_setShortValue_SS, __args);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShortValue", "(SS)S"), __args);
			} finally {
			}
		}

		static Delegate cb_setValue_II;
#pragma warning disable 0169
		static Delegate GetSetValue_IIHandler ()
		{
			if (cb_setValue_II == null)
				cb_setValue_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_SetValue_II);
			return cb_setValue_II;
		}

		static int n_SetValue_II (IntPtr jnienv, IntPtr native__this, int holder, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.BitField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetValue (holder, value);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3']/class[@name='BitField']/method[@name='setValue' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setValue", "(II)I", "GetSetValue_IIHandler")]
		public virtual unsafe int SetValue (int holder, int value)
		{
			if (id_setValue_II == IntPtr.Zero)
				id_setValue_II = JNIEnv.GetMethodID (class_ref, "setValue", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (holder);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setValue_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(II)I"), __args);
			} finally {
			}
		}

	}
}
