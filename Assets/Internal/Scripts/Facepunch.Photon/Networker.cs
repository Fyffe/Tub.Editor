﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Facepunch
{
    [DisallowMultipleComponent]
    public sealed class Networker : MonoBehaviour
    {
        public enum ViewSynchronization { Off, ReliableDeltaCompressed, Unreliable, UnreliableOnChange }

        public int ownerId;
        public byte group = 0;
        public bool OwnerShipWasTransfered;
        public int prefixBackup = -1;
        public ViewSynchronization synchronization;
        public int viewIdField = 0;

        public bool SyncTransforms = true;
        public bool Frozen = false;

#if UNITY_EDITOR
        /*
        void Reset()
        {
            //
            // Move us to the top
            //
            while ( UnityEditorInternal.ComponentUtility.MoveComponentUp( this ) )
            {
            }
        }

        public void OnValidate()
        {
            if ( ObservedComponents == null )
                ObservedComponents = new List<Component>();

            var c = ObservedComponents.Sum( x => x?.GetHashCode() ?? 0 );

            var observables = GetComponents<IPunObservable>();
            ObservedComponents.Clear();
            ObservedComponents.AddRange( observables.Select( x => x as Component ) );
             
            if ( !SyncTransforms )
            {
                ObservedComponents.Remove( this );
            }

            if ( c != ObservedComponents.Sum( x => x.GetHashCode() ) )
            {
                UnityEditor.EditorUtility.SetDirty( gameObject );
            }

            if ( GetComponent<INetworkTakeover>() != null && ownershipTransfer != OwnershipOption.Takeover )
            {
                ownershipTransfer = OwnershipOption.Takeover;
                UnityEditor.EditorUtility.SetDirty( gameObject );
            }

            if ( GetComponent<INetworkTakeover>() == null && ownershipTransfer != OwnershipOption.Fixed )
            {
                ownershipTransfer = OwnershipOption.Fixed;
                UnityEditor.EditorUtility.SetDirty( gameObject );
            }

            if ( ObservedComponents.Count > 0 && synchronization != ViewSynchronization.UnreliableOnChange )
            {
                synchronization = ViewSynchronization.UnreliableOnChange;
                UnityEditor.EditorUtility.SetDirty( gameObject );
            }

            if ( ObservedComponents.Count == 0 && synchronization != ViewSynchronization.Off )
            {
                synchronization = ViewSynchronization.Off;
                UnityEditor.EditorUtility.SetDirty( gameObject );
            }

            if ( SyncTransforms && GetComponent<INetworkStatic>() != null )
            {
                SyncTransforms = false;
                UnityEditor.EditorUtility.SetDirty( gameObject );
            }
        }
        */
#endif
    }
}