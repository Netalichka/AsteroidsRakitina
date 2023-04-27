using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVVM.ViewModel;
using UnityEngine.UI;
using MVVM.Model;

namespace MVVM.View
{

    public class HpView : MonoBehaviour
    {
        [SerializeField] private Text _text;
        private IHpViewModel _hpViewModel;

        public void Initiaalize(IHpViewModel hpViewModel)
        {
            _hpViewModel = hpViewModel;
            _hpViewModel.OnHpChange += OnHpChange;
            OnHpChange(_hpViewModel.HpModel.CurrentHp);
        }

        private void OnHpChange(float currentHp)
        {
            _text.text = _hpViewModel.IsDead ? "вы погибли(" : currentHp.ToString();


        }

        ~HpView()
        {
            _hpViewModel.OnHpChange -= OnHpChange;
        }

    }
}
