import PageComponent from "../components/PageComponent";
import TButton from "../components/core/TButton.jsx";
import { EyeIcon, PencilIcon } from "@heroicons/react/20/solid";

export default function Dashboard() {
  return (
    <PageComponent title="Dashboard">
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-5 text-gray-700">
        <div className="bg-white shadow-md p-3 text-center flex flex-col row-span-2">
          <h3 className="text-2xl font-semibold">Survei Terbaru</h3>
          <div>
            <img
              src="https://i.ibb.co/7pCrh2G/dotnet.jpg" // Replace with a placeholder image
              className="w-[240px] mx-auto"
            />
            <h3 className="font-bold text-xl mb-3">
              <div>.NET</div>
            </h3>
            <div className="flex justify-between text-sm mb-1">
              <div>Tanggal Dibuat:</div>
              <div>20-03-2024</div>
            </div>
            <div className="flex justify-between text-sm mb-1">
              <div>Tanggal Kadaluarsa:</div>
              <div>23-03-2024</div>
            </div>
            <div className="flex justify-between text-sm mb-1">
              <div>Status:</div>
              <div>(Aktif/Draf)</div>
            </div>
            <div className="flex justify-between text-sm mb-1">
              <div>Pertanyaan:</div>
              <div>6</div>
            </div>
            <div className="flex justify-between text-sm mb-3">
              <div>Jawaban:</div>
              <div>0</div>
            </div>
            <div className="flex justify-between">
              <TButton link>
                <PencilIcon className="w-5 h-5 mr-2" />
                Edit Survei
              </TButton>

              <TButton link>
                <EyeIcon className="w-5 h-5 mr-2" />
                Lihat Jawaban
              </TButton>
            </div>
          </div>
        </div>
        <div className="grid grid-rows-2 gap-5 row-span-2">
          <div className="bg-white shadow-md p-3 text-center flex flex-col">
            <h3 className="text-2xl font-semibold">Total Survei</h3>
            <div className="text-8xl pb-4 font-semibold flex-1 flex items-center justify-center">
              <div>3</div>
            </div>
          </div>
          <div className="bg-white shadow-md p-3 text-center flex flex-col">
            <h3 className="text-2xl font-semibold">Total Jawaban</h3>
            <div className="text-8xl pb-4 font-semibold flex-1 flex items-center justify-center">
              <div>0</div>
            </div>
          </div>
        </div>
        <div className="bg-white shadow-md p-3 text-center flex flex-col row-span-2">
            <h3 className="text-2xl font-semibold">Jawaban Terbaru</h3>
            <div className="flex justify-between text-1xl mb-1 font-semibold">
              <h5 className="text-1xl">.NET</h5>
            </div>
            <div className="flex justify-between text-sm mb-1">
              <div>Dibuat: 20-3-2024</div>
            </div>
          </div>
      </div>
    </PageComponent>
  );
}
