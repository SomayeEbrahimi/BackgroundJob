using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.objectbox']/class[@name='VitalDeviceDAO_Objectbox']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/objectbox/VitalDeviceDAO_Objectbox", DoNotGenerateAcw=true)]
	public partial class VitalDeviceDAO_Objectbox : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Repository.Local.Database.IDeviceDAO {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/objectbox/VitalDeviceDAO_Objectbox", typeof (VitalDeviceDAO_Objectbox));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected VitalDeviceDAO_Objectbox (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler ()
		{
			if (cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == null)
				cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_);
			return cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		}

		static void n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox.VitalDeviceDAO_Objectbox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice));
			__this.Delete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.objectbox']/class[@name='VitalDeviceDAO_Objectbox']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalDevice...']]"
		[Register ("delete", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V", "GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler")]
		public virtual unsafe void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0)
		{
			const string __id = "delete.([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_delete_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_arrayLjava_lang_String_ == null)
				cb_delete_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_arrayLjava_lang_String_);
			return cb_delete_arrayLjava_lang_String_;
		}

		static void n_Delete_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox.VitalDeviceDAO_Objectbox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Delete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.objectbox']/class[@name='VitalDeviceDAO_Objectbox']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("delete", "([Ljava/lang/String;)V", "GetDelete_arrayLjava_lang_String_Handler")]
		public virtual unsafe void Delete (params string[] p0)
		{
			const string __id = "delete.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_deleteAll;
#pragma warning disable 0169
		static Delegate GetDeleteAllHandler ()
		{
			if (cb_deleteAll == null)
				cb_deleteAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DeleteAll);
			return cb_deleteAll;
		}

		static void n_DeleteAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox.VitalDeviceDAO_Objectbox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.objectbox']/class[@name='VitalDeviceDAO_Objectbox']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()V", "GetDeleteAllHandler")]
		public virtual unsafe void DeleteAll ()
		{
			const string __id = "deleteAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler ()
		{
			if (cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == null)
				cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_);
			return cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		}

		static void n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox.VitalDeviceDAO_Objectbox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.objectbox']/class[@name='VitalDeviceDAO_Objectbox']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalDevice...']]"
		[Register ("insert", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V", "GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler")]
		public virtual unsafe void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0)
		{
			const string __id = "insert.([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_query_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_arrayLjava_lang_String_Handler ()
		{
			if (cb_query_arrayLjava_lang_String_ == null)
				cb_query_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Query_arrayLjava_lang_String_);
			return cb_query_arrayLjava_lang_String_;
		}

		static IntPtr n_Query_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox.VitalDeviceDAO_Objectbox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice>.ToLocalJniHandle (__this.Query (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.objectbox']/class[@name='VitalDeviceDAO_Objectbox']/method[@name='query' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("query", "([Ljava/lang/String;)Ljava/util/List;", "GetQuery_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> Query (params string[] p0)
		{
			const string __id = "query.([Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_queryAll;
#pragma warning disable 0169
		static Delegate GetQueryAllHandler ()
		{
			if (cb_queryAll == null)
				cb_queryAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_QueryAll);
			return cb_queryAll;
		}

		static IntPtr n_QueryAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox.VitalDeviceDAO_Objectbox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice>.ToLocalJniHandle (__this.QueryAll ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.objectbox']/class[@name='VitalDeviceDAO_Objectbox']/method[@name='queryAll' and count(parameter)=0]"
		[Register ("queryAll", "()Ljava/util/List;", "GetQueryAllHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice> QueryAll ()
		{
			const string __id = "queryAll.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler ()
		{
			if (cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ == null)
				cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_);
			return cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_;
		}

		static void n_Update_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Objectbox.VitalDeviceDAO_Objectbox> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice));
			__this.Update (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.objectbox']/class[@name='VitalDeviceDAO_Objectbox']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalDevice...']]"
		[Register ("update", "([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V", "GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_VitalDevice_Handler")]
		public virtual unsafe void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalDevice[] p0)
		{
			const string __id = "update.([Lcom/vivalnk/sdk/repository/local/database/VitalDevice;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
