import { PencilIcon, ArrowTopRightOnSquareIcon, TrashIcon } from '@heroicons/react/20/solid'
import React from 'react'
import TButton from './core/TButton';

export default function SurveyListItem({ survey, onDeleteClick }) {
    return (
        <>
        <div className="flex flex-col py-4 px-6 shadow-md bg-white hover:bg-gray-h[470px] rounded-xl">
            <img
                src={survey.image_url}
                alt={survey.title}
                className="w-full h-52 object-cover rounded-xl border-solid border-2 border-gray-200"
            />
            <h4 className="mt-4 text-lg font-bold">{survey.title}</h4>
            <div dangerouslySetInnerHTML={{__html: survey.description}} 
                className="overflow-hidden flex-1"></div>

            <div className="flex justify-between items-center mt-3">
                <TButton to={`surveys/${survey.id}`}>
                    <PencilIcon className="w-5 h-5 mr-2 "/>
                         Edit
                </TButton>
            </div>

            <div className="flex justify-between items-center mt-3">
            <TButton href={`/view/survey/${survey.slug}`} circle link>
                <ArrowTopRightOnSquareIcon className="w-5 h-5"/>
            </TButton>

            {survey.id && (
            <TButton onClick={onDeleteClick} circle link color="red">
                <TrashIcon className="w-5 h-5"/>
            </TButton>)}
            </div>
        </div>
        </>
    )
}
