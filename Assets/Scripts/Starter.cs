using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVVM.Model;
using MVVM.View;
using MVVM.ViewModel;

namespace MVVM
{

    public class Starter : MonoBehaviour
    {

        [SerializeField] private HpView _hpView;
        [SerializeField] private ApplayDamdgeView _applayDamdgeView;
        // Start is called before the first frame update
        private void Start()
        {
            var hpModel = new HpModel(100);
            var hpViewModel = new HpViewModel(hpModel);
            _hpView.Initiaalize(hpViewModel);
            _applayDamdgeView.Initialize(hpViewModel);
        }

        
    }
}
