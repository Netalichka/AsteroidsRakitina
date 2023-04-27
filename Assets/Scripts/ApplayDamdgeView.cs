using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVVM.ViewModel;
using UnityEngine.UI;

namespace MVVM.View
{

    public class ApplayDamdgeView : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private float _damage;
        private IHpViewModel _hpViewModel;

        public void Initialize(IHpViewModel hpViewModel)
        {
            _hpViewModel = hpViewModel;
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _hpViewModel.ApplyDamage(_damage));

        }
    }
}
