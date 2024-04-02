import React from 'react';
import PageComponent from '../components/PageComponent';
import { UserIcon } from '@heroicons/react/24/outline';

const developers = [
  {
    name: 'Lionel',
    description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sit amet pretium lectus, non hendrerit risus. Nulla facilisi. Nunc velit risus, dapibus in suscipit vel, rutrum eget nibh. Quisque velit nisi, tincidunt eget lacus eget, ultricies ultrices eros.',
  },
  {
    name: 'Arimby',
    description: 'Praesent eget tortor ac nibh tincidunt ullamcorper. Nunc euismod, dolor eget feugiat ultrices, nisl lectus feugiat risus, eget aliquet ipsum eros eget neque. Fusce velit neque, accumsan eget neque eget, ultricies ultricies eros.',
  },
  {
    name: 'Amil',
    description: 'Mauris sit amet pretium lectus, non hendrerit risus. Nulla facilisi. Nunc velit risus, dapibus in suscipit vel, rutrum eget nibh. Quisque velit nisi, tincidunt eget lacus eget, ultricies ultrices eros.',
  },
];

export default function Team() {
  return (
    <>
      <PageComponent title="Developer">
        <h1 className="text-3xl font-bold text-center mb-4">Our Development Team</h1>
        <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-4">
          {developers.map((developer, index) => (
            <div key={index} className="flex flex-col items-center justify-center p-4 rounded-xl shadow-md bg-white h-96 w-80">
              <UserIcon className="w-24 h-24 text-indigo-500 bg-slate-40 rounded-full" />
              <h2 className="text-xl font-semibold mt-4">{developer.name}</h2>
              <p className="text-gray-700 mt-2 text-center">{developer.description}</p>
            </div>
          ))}
        </div>

      </PageComponent>
    </>
  );
}
