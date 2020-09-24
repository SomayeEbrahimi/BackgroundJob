using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Local.Database.Room {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/local/database/room/VitalDataDAO_Room", DoNotGenerateAcw=true)]
	public partial class VitalDataDAO_Room : global::Java.Lang.Object, global::Com.Vivalnk.Sdk.Repository.Local.Database.IDataDAO {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/field[@name='dao']"
		[Register ("dao")]
		public global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO Dao {
			get {
				const string __id = "dao.Lcom/vivalnk/sdk/repository/local/database/room/IRoomDataDAO;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.IRoomDataDAO> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dao.Lcom/vivalnk/sdk/repository/local/database/room/IRoomDataDAO;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/local/database/room/VitalDataDAO_Room", typeof (VitalDataDAO_Room));
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

		protected VitalDataDAO_Room (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCount);
			return cb_getCount;
		}

		static long n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public virtual unsafe long Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()J", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
#pragma warning disable 0169
		static Delegate GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler ()
		{
			if (cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == null)
				cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_);
			return cb_delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		}

		static void n_Delete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData));
			__this.Delete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData...']]"
		[Register ("delete", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V", "GetDelete_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler")]
		public virtual unsafe void Delete (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0)
		{
			const string __id = "delete.([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()V", "GetDeleteAllHandler")]
		public virtual unsafe void DeleteAll ()
		{
			const string __id = "deleteAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCount_Ljava_lang_String_Handler ()
		{
			if (cb_getCount_Ljava_lang_String_ == null)
				cb_getCount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetCount_Ljava_lang_String_);
			return cb_getCount_Ljava_lang_String_;
		}

		static long n_GetCount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetCount (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='getCount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCount", "(Ljava/lang/String;)J", "GetGetCount_Ljava_lang_String_Handler")]
		public virtual unsafe long GetCount (string p0)
		{
			const string __id = "getCount.(Ljava/lang/String;)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler ()
		{
			if (cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == null)
				cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_);
			return cb_insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		}

		static void n_Insert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData...']]"
		[Register ("insert", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V", "GetInsert_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler")]
		public virtual unsafe void Insert (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0)
		{
			const string __id = "insert.([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V";
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

		static Delegate cb_query_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_JHandler ()
		{
			if (cb_query_Ljava_lang_String_J == null)
				cb_query_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_Query_Ljava_lang_String_J);
			return cb_query_Ljava_lang_String_J;
		}

		static IntPtr n_Query_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='query' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("query", "(Ljava/lang/String;J)Lcom/vivalnk/sdk/repository/local/database/VitalData;", "GetQuery_Ljava_lang_String_JHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData Query (string p0, long p1)
		{
			const string __id = "query.(Ljava/lang/String;J)Lcom/vivalnk/sdk/repository/local/database/VitalData;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_query_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_JJHandler ()
		{
			if (cb_query_Ljava_lang_String_JJ == null)
				cb_query_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJ_L) n_Query_Ljava_lang_String_JJ);
			return cb_query_Ljava_lang_String_JJ;
		}

		static IntPtr n_Query_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.ToLocalJniHandle (__this.Query (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='query' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("query", "(Ljava/lang/String;JJ)Ljava/util/List;", "GetQuery_Ljava_lang_String_JJHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> Query (string p0, long p1, long p2)
		{
			const string __id = "query.(Ljava/lang/String;JJ)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.ToLocalJniHandle (__this.QueryAll ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='queryAll' and count(parameter)=0]"
		[Register ("queryAll", "()Ljava/util/List;", "GetQueryAllHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> QueryAll ()
		{
			const string __id = "queryAll.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_queryAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueryAll_Ljava_lang_String_Handler ()
		{
			if (cb_queryAll_Ljava_lang_String_ == null)
				cb_queryAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_QueryAll_Ljava_lang_String_);
			return cb_queryAll_Ljava_lang_String_;
		}

		static IntPtr n_QueryAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.ToLocalJniHandle (__this.QueryAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='queryAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryAll", "(Ljava/lang/String;)Ljava/util/List;", "GetQueryAll_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> QueryAll (string p0)
		{
			const string __id = "queryAll.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_queryLatestAll_J;
#pragma warning disable 0169
		static Delegate GetQueryLatestAll_JHandler ()
		{
			if (cb_queryLatestAll_J == null)
				cb_queryLatestAll_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_QueryLatestAll_J);
			return cb_queryLatestAll_J;
		}

		static IntPtr n_QueryLatestAll_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.ToLocalJniHandle (__this.QueryLatestAll (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='queryLatestAll' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("queryLatestAll", "(J)Ljava/util/List;", "GetQueryLatestAll_JHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> QueryLatestAll (long p0)
		{
			const string __id = "queryLatestAll.(J)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_queryOldestAll_J;
#pragma warning disable 0169
		static Delegate GetQueryOldestAll_JHandler ()
		{
			if (cb_queryOldestAll_J == null)
				cb_queryOldestAll_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_QueryOldestAll_J);
			return cb_queryOldestAll_J;
		}

		static IntPtr n_QueryOldestAll_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.ToLocalJniHandle (__this.QueryOldestAll (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='queryOldestAll' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("queryOldestAll", "(J)Ljava/util/List;", "GetQueryOldestAll_JHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData> QueryOldestAll (long p0)
		{
			const string __id = "queryOldestAll.(J)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
#pragma warning disable 0169
		static Delegate GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler ()
		{
			if (cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ == null)
				cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_);
			return cb_update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_;
		}

		static void n_Update_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Local.Database.Room.VitalDataDAO_Room> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData));
			__this.Update (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.local.database.room']/class[@name='VitalDataDAO_Room']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData...']]"
		[Register ("update", "([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V", "GetUpdate_arrayLcom_vivalnk_sdk_repository_local_database_VitalData_Handler")]
		public virtual unsafe void Update (params global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData[] p0)
		{
			const string __id = "update.([Lcom/vivalnk/sdk/repository/local/database/VitalData;)V";
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
