import { } from 'react';
import './App.css';
import PlanetList from './views/PlanetsList'
import {Routes, Route, Navigate } from "react-router-dom"



export default function App() {
    return (
        <Routes>
            <Route path="/" element={<Navigate to="/planets" replace />} />
            <Route path="/planets" element={<PlanetList />} />
        </Routes>
    );
}

