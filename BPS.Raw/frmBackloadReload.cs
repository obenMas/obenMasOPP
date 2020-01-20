using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPS.Raw
{
    public partial class frmBackloadReload : Form
    {
        List<clsPallet> pltList = new List<clsPallet>();

        //Nuevo Ejemplo
        private readonly SynchronizationContext synchronizationContext;
        //private DateTime previousTime = DateTime.Now;

        public frmBackloadReload()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
        }

        private void frmBackloadReload_Load(object sender, EventArgs e)
        {
            //Control.CheckForIllegalCrossThreadCalls = false;
            //GetPalletInfo();
            GetPalletInfoR();
            //aaaa();
        }

        private void aaaa()
        {
            var palList = Task.Factory.StartNew(() =>
            {
                return clsPallet.getListForBackLoadReload();
            });

            var processData = palList.ContinueWith((pallet) =>
            {
                PopGrid(pallet.Result);
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            try
            {
                palList.Wait();
                processData.Wait();
            }

            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                    MessageBox.Show(e.Message);
            }

        }

        delegate void PopGridDelegate(List<clsPallet> list);

        private void PopGrid(List<clsPallet> list)
        {
            if (this.InvokeRequired)
            {
                PopGridDelegate pop = new PopGridDelegate(PopGrid);
                object[] par = new object[] { list };
                this.Invoke(pop, par);
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = list[i].codsec;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = list[i].code;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();

                }
            }
        }

        //public class TicTac
        //{
        //    public void Tic(bool enEjecucion)
        //    {
        //        lock (this)
        //        {
        //            if (!enEjecucion)
        //            {
        //                // Notifica a los threads en espera:
        //                Monitor.Pulse(this);
        //                return;
        //            }
        //            Thread.Sleep(1000);
        //            Console.Write("Tic ");

        //            // Permite el paso de la ejecución del método Tac
        //            Monitor.Pulse(this);

        //            // ...y espera a que el método Tac termine:
        //            Monitor.Wait(this);
        //        }
        //    }

        //    public void Tac(bool enEjecucion)
        //    {
        //        lock (this)
        //        {
        //            if (!enEjecucion)
        //            {
        //                // Notifica a los threads en espera:
        //                Monitor.Pulse(this);
        //                return;
        //            }
        //            Thread.Sleep(1000);
        //            Console.WriteLine("Tac");

        //            // Permite el paso de la ejecución del método Tic
        //            Monitor.Pulse(this);

        //            // ...y espera a que el método Tic termine:
        //            Monitor.Wait(this);
        //        }
        //    }
        //}

        //public sealed class TicTacPulse
        //{
        //    public static TicTac ticTac;

        //    public static void IniciarReloj()
        //    {
        //        if (Thread.CurrentThread.Name.Equals("Tic"))
        //        {
        //            // Repite el sonido tic 5 veces:
        //            for (int i = 1; i <= 5; ++i)
        //            {
        //                ticTac.Tic(true);
        //            }

        //            // Detiene el sonido tic:
        //            ticTac.Tic(false);
        //        }
        //        else
        //        {
        //            // Repite el sonido tac 5 veces:
        //            for (int i = 1; i <= 5; ++i)
        //            {
        //                ticTac.Tac(true);
        //            }

        //            // Detiene el sonido tac:
        //            ticTac.Tac(false);
        //        }
        //    }
        //}

        //private void GetPalletInfoRR()
        //{
        //    TicTac ticTac = new TicTac();

        //    // Crea dos threads:
        //    Thread t1 = new Thread(IniciarReloj);
        //    t1.Name = "Tic";
        //    Thread t2 = new Thread(IniciarReloj);
        //    t2.Name = "Tac";

        //    t1.Start();
        //    t2.Start();

        //    t1.Join();
        //    t2.Join();

        //    Console.WriteLine("\nEl reloj se ha detenido. Presione Enter.");
        //    Console.ReadLine();

        //    //ThreadPool.QueueUserWorkItem(arg1);
        //    //ThreadPool.QueueUserWorkItem(arg2);

        //    //ThreadStart testThread1Start = new ThreadStart(arg1);
        //    //ThreadStart testThread2Start = new ThreadStart(arg2);

        //    //Thread[] testThread = new Thread[2];
        //    //testThread[0] = new Thread(arg1);
        //    //testThread[1] = new Thread(arg2);

        //    //testThread[0].Start();
        //    //testThread[1].Start();
        //    //testThread[0].Join();
        //    //testThread[1].Join();



        //    //foreach (Thread myThread in testThread)
        //    //{
        //    //    myThread.Start();
        //    //}
        //}

        //private void IniciarReloj(object obj)
        //{
        //    TicTac ticTac;

        //    if (Thread.CurrentThread.Name.Equals("Tic"))
        //    {
        //        // Repite el sonido tic 5 veces:
        //        for (int i = 1; i <= 5; ++i)
        //        {
        //            ticTac.Tic(true);
        //        }

        //        // Detiene el sonido tic:
        //        ticTac.Tic(false);
        //    }
        //    else
        //    {
        //        // Repite el sonido tac 5 veces:
        //        for (int i = 1; i <= 5; ++i)
        //        {
        //            ticTac.Tac(true);
        //        }

        //        // Detiene el sonido tac:
        //        ticTac.Tac(false);
        //    }
        //}

        //private void arg2(object f)
        //{
        //    Console.WriteLine("Chao desde : " + Thread.CurrentThread.ManagedThreadId);
        //}

        //private void arg1(Object t)
        //{
        //    Thread.Sleep(5000);
        //    Console.WriteLine("Hola desde : " + Thread.CurrentThread.ManagedThreadId);
        //}

        //private void arg2()
        //{
        //    Console.WriteLine("Chao desde : " + Thread.CurrentThread.ManagedThreadId);
        //}

        //private void arg1()
        //{
        //    Thread.Sleep(5000);
        //    Console.WriteLine("Hola desde : " + Thread.CurrentThread.ManagedThreadId);
        //}

        //private async Task GetPalletInfo()
        //{
        //    label12.Text = "Inicio..";
        //    var count = 0;

        //    await Task.Run(() =>
        //    {
        //        for (var i = 0; i <= 50000; i++)
        //        {
        //            UpdateUI(i);
        //            count = i;
        //        }
        //    });

        //    label12.Text = @"Counter " + count;
        //}

        //public void UpdateUI(int value)
        //{
        //    var timeNow = DateTime.Now;

        //    if ((DateTime.Now - previousTime).Milliseconds <= 50) return;

        //    synchronizationContext.Post(new SendOrPostCallback(o =>
        //    {
        //        label12.Text = @"Counter " + (int)o;
        //    }), value);

        //    previousTime = timeNow;
        //}

        private async void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            //GetPalletInfo();
            //GetPalletInfoR();
            testc();
        }

        private async Task testc()
        {
            // Call the method that runs asynchronously.
            //string result = await WaitAsynchronouslyAsync();

            // Call the method that runs synchronously.
            string result = await WaitSynchronously();

            // Display the result.
            label12.Text += result;
        }

        // The following method runs asynchronously. The UI thread is not
        // blocked during the delay. You can move or resize the Form1 window 
        // while Task.Delay is running.
        public async Task<string> WaitAsynchronouslyAsync()
        {
            await Task.Delay(10000);
            return "Finished";
        }

        // The following method runs synchronously, despite the use of async.
        // You cannot move or resize the Form1 window while Thread.Sleep
        // is running because the UI thread is blocked.
        public async Task<string> WaitSynchronously()
        {
            // Add a using directive for System.Threading.
            Thread.Sleep(10000);
            return "Finished";
        }

        private async Task GetPalletInfoR()
        {
            pltList = clsPallet.getListForBackLoadReload();

            var demoThread = new Thread(new ThreadStart(this.ThreadProcUnsafe));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;

            var demoThread2 = new Thread(new ThreadStart(this.ThreadProcUnsafe2));
            demoThread2.Start();
            demoThread2.Priority = ThreadPriority.Highest;

            var demoThread3 = new Thread(new ThreadStart(this.ThreadProcUnsafe3));
            demoThread3.Start();
            demoThread3.Priority = ThreadPriority.Highest;






            //var palList = Task.Factory.StartNew(() =>
            //{
            //    for (int i = 0; i < pltList.Count; i++)
            //        cmbFilm.Items.Add(pltList[i].code);
            //});

            //palList.Wait();

            //var processData = palList.ContinueWith((pallet) =>
            //{
            //    for (int i = 0; i < palList.Result.Count; i++)
            //    {
            //        dgvDetails.Rows.Add();
            //        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = palList.Result.Select(pt => pt.codsec);
            //        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = palList.Result.Select(pt => pt.code);
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
            //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();
            //    }
            //}, TaskContinuationOptions.OnlyOnRanToCompletion);

            //try
            //{
            //    palList.Wait();
            //    processData.Wait();
            //}

            //catch (AggregateException ae)
            //{
            //    foreach (var e in ae.InnerExceptions)
            //        MessageBox.Show(e.Message);
            //}
        }

        delegate void ThreadProcUnsafe3Delegate();

        private async void ThreadProcUnsafe3()
        {
            if (this.InvokeRequired)
            {
                ThreadProcUnsafe3Delegate pop = new ThreadProcUnsafe3Delegate(ThreadProcUnsafe3);
                this.Invoke(pop);
            }
            else
            {
                for (var i = 0; i <= pltList.Count - 1; i++)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = pltList[i].codsec;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = pltList[i].code;
                    label12.Text = "pos " + i + "de " + pltList.Count();
                    await Task.Delay(1);
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                }
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }
        }

        delegate void ThreadProcUnsafe2Delegate();

        private void ThreadProcUnsafe2()
        {
            if (this.InvokeRequired)
            {
                ThreadProcUnsafe2Delegate pop = new ThreadProcUnsafe2Delegate(ThreadProcUnsafe2);
                this.Invoke(pop);
            }
            else
            {
                cmbCustomer.Items.Add("CHAO");
                cmbCustomer.Items.Add("CHAO");
                cmbCustomer.Items.Add("CHAO");
                cmbCustomer.Items.Add("CHAO");
                cmbCustomer.Items.Add("CHAO");
                cmbCustomer.Items.Add("CHAO");
                cmbCustomer.Items.Add("CHAO");
                cmbCustomer.Items.Add("CHAO");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }
        }

        delegate void ThreadProcUnsafeDelegate();

        private void ThreadProcUnsafe()
        {
            if (this.InvokeRequired)
            {
                ThreadProcUnsafeDelegate pop = new ThreadProcUnsafeDelegate(ThreadProcUnsafe);
                this.Invoke(pop);
            }
            else
            {
                cmbFilm.Items.Add("Hola");
                cmbFilm.Items.Add("Hola");
                cmbFilm.Items.Add("Hola");
                cmbFilm.Items.Add("Hola");
                cmbFilm.Items.Add("Hola");
                cmbFilm.Items.Add("Hola");
                cmbFilm.Items.Add("Hola");
                cmbFilm.Items.Add("Hola");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }
        }

        //private async Task GetPalletInfo()
        //{
        //    label12.Text = "Inicio..";
        //    Console.WriteLine("Current thread: " + Thread.CurrentThread.ManagedThreadId);
        //    pltList = await SomeFastAsyncOperation().ConfigureAwait(false);
        //    Console.WriteLine("Current thread: " + Thread.CurrentThread.ManagedThreadId);
        //    await SomeSlowAsyncOperation();
        //    Console.WriteLine("Current thread: " + Thread.CurrentThread.ManagedThreadId);
        //    Task.WaitAll();
        //    llenar(pltList.Count);
        //    //label12.Text = "Fin de Otro lado..";
        //}

        //delegate void llenarDelegate(int pltList);
        //private void llenar(int pltList)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        llenarDelegate pop = new llenarDelegate(llenar);
        //        object[] par = new object[] { pltList };
        //        this.Invoke(pop, par);
        //    }
        //    else
        //    {
        //        label12.Text = "Fin.. con archivos :" + pltList.ToString();
        //    }
        //}

        //

        //private void popoup(List<clsPallet> list)
        //{

        //        Parallel.For(0, pltList.Count, i =>
        //        {

        //private Task<List<clsPallet>> SomeFastAsyncOperation()
        //{
        //    return Task.FromResult(clsPallet.getListForBackLoadReload());
        //}

        //private async Task<string> SomeSlowAsyncOperation()
        //{
        //    const string url = "http://www.matlus.com";
        //    var httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
        //    var webResponse = await httpWebRequest.GetResponseAsync();
        //    return "HTML";
        //}

        //private void GetPalletInfo()
        //{
        //    const string url = "http://www.matlus.com";
        //    DonwnloadHtml(url);
        //    DonwnloadHtmlAsync(url);
        //    MessageBox.Show("Fin");
        //}

        //private void DonwnloadHtml(string url)
        //{
        //    var httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
        //    httpWebRequest.BeginGetResponse(ar =>
        //        {
        //            var webResponse = httpWebRequest.EndGetResponse(ar);
        //            using (var responseStream = webResponse.GetResponseStream())
        //            {
        //                var manualResetEvent = new ManualResetEvent(false);

        //                var buffer = new byte[2048];
        //                AsyncCallback readCallback = null;

        //                readCallback = iar =>
        //                    {
        //                        var bytesRead = responseStream.EndRead(iar);
        //                        if (bytesRead > 0)
        //                        {
        //                            Console.WriteLine("HTML");
        //                            responseStream.BeginRead(buffer, 0, buffer.Length, readCallback, null);
        //                        }
        //                        else
        //                            manualResetEvent.Set();
        //                    };

        //                responseStream.BeginRead(buffer, 0, buffer.Length, readCallback, null);
        //                manualResetEvent.WaitOne();
        //            }
        //        }, null);
        //}

        //private async Task DonwnloadHtmlAsync(string url)
        //{
        //    var httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
        //    var webResponse = await httpWebRequest.GetResponseAsync();
        //    using (var responseStream = webResponse.GetResponseStream())
        //    {
        //        var buffer = new byte[2048];
        //        var bytesRead = 0;

        //        while ((bytesRead = await responseStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
        //        {
        //            Console.WriteLine("HTML");
        //        }
        //    }
        //}

        ////private void GetPalletInfo()
        ////{
        ////    var demoThread = new Thread(new ThreadStart(this.ThreadProcUnsafe));
        ////    demoThread.Start();
        ////    demoThread.Priority = ThreadPriority.Highest;

        ////    PopulateGrid();

        ////    //var populateGrid = new Thread(new ThreadStart(this.PopulateGrid));
        ////    //demoThread.Join();
        ////    //demoThread.Priority = ThreadPriority.Highest;
        ////}

        ////private void PopulateGrid()
        ////{
        ////    Parallel.For(0, pltList.Count, i =>
        ////    {
        ////        dgvDetails.Rows.Add();
        ////        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = pltList[i].codsec;
        ////        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = pltList[i].code;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
        ////        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();

        ////    });
        ////}

        ////private void ThreadProcUnsafe()
        ////{
        ////    pltList = clsPallet.getListForBackLoadReload();
        ////    popoup(pltList);
        ////}

        ////private void GetPalletInfo()
        ////{
        ////    var context = TaskScheduler.FromCurrentSynchronizationContext();

        ////    this.label12.Text = "Starting task...";

        ////    // Start a task - this runs on the background thread...
        ////    Task.Factory.StartNew(delegate
        ////    {
        ////        pltList = clsPallet.getListForBackLoad();
        ////        popoup(pltList);

        ////        Invoke((Action)(() => { this.label12.Text = "Task Complete!"; }));
        ////    });
        ////}

        //delegate void popoupDelegate(List<clsPallet> list);

        //private void popoup(List<clsPallet> list)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        popoupDelegate pop = new popoupDelegate(popoup);
        //        object[] par = new object[] { list };
        //        this.Invoke(pop, par);
        //    }
        //    else
        //    {
        //        Parallel.For(0, pltList.Count, i =>
        //        {
        //            dgvDetails.Rows.Add();
        //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = pltList[i].codsec;
        //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = pltList[i].code;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();

        //        });
        //    }
        //}

        //private void Pop()
        //{
        //    Parallel.For(0, pltList.Count, i =>
        //    {
        //        dgvDetails.Rows.Add();
        //        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = pltList[i].codsec;
        //        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = pltList[i].code;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
        //        //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();

        //    });
        //}

        //private void GetPalletInfo()
        //{
        //    var context = TaskScheduler.FromCurrentSynchronizationContext();

        //    this.label12.Text = "Starting task...";

        //    // Start a task - this runs on the background thread...
        //    Task task = Task.Factory.StartNew(() =>
        //    {
        //        // Do some fake work...
        //        clsPallet.getListForBackLoad();

        //        //foreach (var item in clsPallet.getListForBackLoad())
        //        //{
        //        //    dgvDetails.Rows.Add();
        //        //    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = item.codsec;
        //        //    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = item.code;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
        //        //    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();
        //        //}

        //        // It's possible to start a task directly on
        //        // the UI thread, but not common...
        //        var token = Task.Factory.CancellationToken;
        //        Task.Factory.StartNew(() =>
        //        {
        //            this.label12.Text = "Task past first work section...";
        //        }, token, TaskCreationOptions.None, context);

        //        // Do a bit more work
        //        Thread.Sleep(5000);
        //    })
        //        // More commonly, we'll continue a task with a new task on
        //        // the UI thread, since this lets us update when our
        //        // "work" completes.
        //        .ContinueWith(_ =>
        //            this.label12.Text = "Task Complete!", context);
        //}

        //delegate void GetPallletInfoDelegate();

        //private void GetPalletInfo()
        //{
        //    if (this.InvokeRequired)
        //    {
        //        GetPallletInfoDelegate dlPallet = new GetPallletInfoDelegate(GetPalletInfo);
        //        this.Invoke(dlPallet);
        //    }

        //    var palList = Task.Factory.StartNew(() =>
        //    {
        //        return clsPallet.getListForBackLoad();
        //    });

        //    var processData = palList.ContinueWith((pallet) =>
        //    {
        //        for (int i = 0; i < palList.Result.Count; i++)
        //        {
        //            dgvDetails.Rows.Add();
        //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = palList.Result.Select(pt => pt.codsec);
        //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = palList.Result.Select(pt => pt.code);
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
        //            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();
        //        }
        //    }, TaskContinuationOptions.OnlyOnRanToCompletion);

        //    try
        //    {
        //        palList.Wait();
        //        processData.Wait();
        //    }

        //    catch (AggregateException ae)
        //    {
        //        foreach (var e in ae.InnerExceptions)
        //            MessageBox.Show(e.Message);
        //    }
        //}
    }
}

