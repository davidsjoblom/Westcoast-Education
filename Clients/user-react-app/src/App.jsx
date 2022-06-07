import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';

import Navbar from './components/navbar/Navbar';
import Home from './components/home/Home';
import CourseList from './components/courses/CourseList';
import SubjectList from './components/subjects/Subjectlist';

import './styles.css';

function App() {
    return (
        <Router>
            <Navbar />
            <main>
                <Routes>
                    <Route path='/' element={<Home />} />
                    <Route path='/courses' element={<CourseList />} />
                    <Route path='/subjects' element={<SubjectList />} />
                </Routes>
            </main>
        </Router>
    )
}

export default App;