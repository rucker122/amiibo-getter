using amiibo_getter.Constant;
using amiibo_getter.Models;
using System.Text.Json;

namespace amiibo_getter
{
    public partial class amiibo : Form
    {
        private string IDNO;
        private const int SKIP_COUNT_CONDITION = 3;
        private List<AmiiboData> AMIIBO_DATA_LIST = new();
        private List<string> AMIIBO_SERIES_LIST = new();
        private PROCESS_STATUS PROCESS_STATUS;

        public amiibo()
        {
            InitializeComponent();
        }

        private async void btn_Fetch_Click(object sender, EventArgs e)
        {
            // initial GridView and AMIIBO_DATA_LIST
            InitialData();
            SetStatus(PROCESS_STATUS.Fetching);
            
            // set empty data count
            int emptyCount = 0;
            // get current time for calc elapsed time
            TimeOnly startTime = TimeOnly.FromDateTime(DateTime.Now);
            while (PROCESS_STATUS == PROCESS_STATUS.Fetching)
            {
                // taking idno
                IDNO = DataHelper.getNextIdno(IDNO, emptyCount >= SKIP_COUNT_CONDITION);

                // set process text
                SetProcessBarText($"Fetching: {IDNO}");

                // fetch web content to model via idno
                string html = await DataHelper.GetHtml($"{ENV_CONST.AMIIBO_PAGE_URL}/{IDNO}");
                AmiiboData amiiboData = DataHelper.HtmlToAmiiboData(html);

                // if no amiibo name means there's no data, do continue and add emptyCount
                if (string.IsNullOrWhiteSpace(amiiboData.Name))
                {
                    emptyCount++;
                    continue;
                }

                // add model to LIST
                amiiboData.Indo = IDNO;
                AMIIBO_DATA_LIST.Add(amiiboData);
                // reset emptyCount to zero
                emptyCount = 0;
            } 

            // set process text
            SetProcessBarText("Syncing.");
            ProcessResult(AMIIBO_DATA_LIST);
            SetStatus(PROCESS_STATUS.Idle);

            // set process text
            TimeOnly endTime = TimeOnly.FromDateTime(DateTime.Now);
            SetProcessBarText($"Complete. Elapsed time: {endTime - startTime}, {AMIIBO_DATA_LIST.Count()} amiibos.");
        }

        private void SetStatus(PROCESS_STATUS status)
        {
            PROCESS_STATUS = status;

            switch(status)
            {
                case PROCESS_STATUS.Idle:
                    btn_Fetch.Text = "Fetch";
                    btn_Fetch.Click += new System.EventHandler(btn_Fetch_Click);
                    btn_Fetch.Click -= (object sender, EventArgs e) => { PROCESS_STATUS = PROCESS_STATUS.Idle; };
                    break;
                case PROCESS_STATUS.Fetching:
                    btn_Fetch.Text = "Stop";
                    btn_Fetch.Click -= new System.EventHandler(btn_Fetch_Click);
                    btn_Fetch.Click += (object sender, EventArgs e) => { PROCESS_STATUS = PROCESS_STATUS.Idle; };
                    break;
            }
        }

        private void ProcessResult(List<AmiiboData> outputList)
        {
            // accessing LIST DATA to GridView Cells
            foreach (AmiiboData data in outputList)
            {
                int idx = gv_amiibo.Rows.Add();
                DataGridViewRow row = gv_amiibo.Rows[idx];
                row.Cells["gv_Idno"].Value = data.Indo;
                row.Cells["gv_AmiiboName"].Value = data.Name;
                row.Cells["gv_AmiiboSeries"].Value = data.Series.Name;
                row.Cells["gv_ReleaseDate"].Value = data.ReleaseDate;
            }

            // convert to json string
            tb_Json.Text = JsonSerializer.Serialize(outputList);
        }

        private void InitialData()
        {
            gv_amiibo.Rows.Clear();
            AMIIBO_DATA_LIST.Clear();
            IDNO = string.Empty;
        }

        private void SetProcessBarText(string text)
        {
            processBar.Text = text;
        }

        private void gv_amiibo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string idno = gv_amiibo.Rows[e.RowIndex].Cells["gv_Idno"].Value.ToString()!;
            string Image_Url = $"{ENV_CONST.AMIIBO_IMAGE_URL}/{idno}.jpg";
            pictureBox1.Load(Image_Url);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}