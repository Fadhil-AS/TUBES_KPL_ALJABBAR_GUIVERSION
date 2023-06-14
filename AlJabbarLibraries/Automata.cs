using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlJabbarLibraries
{
    public class Automata
    {
        public enum prosesPesan
        {
            BERANDA,
            PILIHWAKTU,
            RINCIAN
        }

        public enum Trigger
        {
            PILIH_TUJUAN,
            PILIH_WAKTU
        }

        public prosesPesan currentState = prosesPesan.BERANDA;

        public class Transition
        {
            public prosesPesan stateAwal;
            public prosesPesan stateAkhir;
            public Trigger trigger;

            public Transition(prosesPesan stateAwal, prosesPesan stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        Transition[] transisi =
        {
                new Transition(prosesPesan.BERANDA, prosesPesan.PILIHWAKTU, Trigger.PILIH_TUJUAN),
                new Transition(prosesPesan.PILIHWAKTU, prosesPesan.RINCIAN, Trigger.PILIH_WAKTU),
                new Transition(prosesPesan.PILIHWAKTU, prosesPesan.BERANDA, Trigger.PILIH_TUJUAN)
            };

        public prosesPesan getStateBerikutnya(prosesPesan stateAwal, Trigger trigger)
        {
            prosesPesan stateAkhir = stateAwal;

            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];

                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }
            currentState = stateAkhir;
            return currentState;
        }

        public prosesPesan activateTrigger(Trigger trigger)
        {
            currentState = getStateBerikutnya(currentState, trigger);
            return currentState;
        }

        public void printCurrentState()
        {
            Console.WriteLine("State sekarang adalah : " + currentState);
        }
    }
}
